using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace DoclingServe.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string DoclingServeImage = "quay.io/docling-project/docling-serve-cpu:latest";
    private const ushort DoclingServePort = 5001;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(5);

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
                        : null;

                var client = apiKey is not null
                    ? new DoclingServeClient(apiKey, baseUri: new Uri(baseUrl))
                    : new DoclingServeClient(baseUri: new Uri(baseUrl));

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
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(DoclingServePort)).Uri);

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
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
