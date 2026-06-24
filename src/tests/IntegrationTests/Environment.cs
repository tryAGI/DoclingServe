using System.Diagnostics;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace DoclingServe.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string DoclingServeImage = "quay.io/docling-project/docling-serve-cpu:latest";
    private const ushort DoclingServePort = 5001;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(10);

    public IContainer? Container { get; init; }
    public required DoclingServeClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var baseUrl =
                    System.Environment.GetEnvironmentVariable("DOCLINGSERVE_BASE_URL") is { Length: > 0 } baseUrlValue
                        ? baseUrlValue
                        : $"http://127.0.0.1:{DoclingServePort}";

                var apiKey =
                    System.Environment.GetEnvironmentVariable("DOCLINGSERVE_API_KEY") is { Length: > 0 } apiKeyValue
                        ? apiKeyValue
                        : "test";

                var client = new DoclingServeClient(apiKey, baseUri: new Uri(baseUrl));
                client.AuthorizeUsingAuthorization();

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                var container = new ContainerBuilder(DoclingServeImage)
                    .WithPortBinding(DoclingServePort, assignRandomHostPort: true)
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/health")
                                .ForPort(DoclingServePort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var client = new DoclingServeClient(
                    "test",
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(DoclingServePort)).Uri);
                client.AuthorizeUsingAuthorization();

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static EnvironmentType InferEnvironment()
    {
        if (System.Environment.GetEnvironmentVariable("DOCLINGSERVE_TEST_ENVIRONMENT") is { Length: > 0 } environmentValue &&
            Enum.TryParse<EnvironmentType>(environmentValue, ignoreCase: true, out var environmentType))
        {
            return environmentType;
        }

        if (System.Environment.GetEnvironmentVariable("DOCLINGSERVE_BASE_URL") is not { Length: > 0 } &&
            IsDockerAvailable())
        {
            return EnvironmentType.Container;
        }

#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }

    private static bool IsDockerAvailable()
    {
        try
        {
            using var process = Process.Start(new ProcessStartInfo
            {
                FileName = "docker",
                ArgumentList = { "info", "--format", "{{.ServerVersion}}" },
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            });

            return process is not null &&
                   process.WaitForExit(milliseconds: 5000) &&
                   process.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
