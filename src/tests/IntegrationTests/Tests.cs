namespace DoclingServe.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DoclingServeClient GetAuthenticatedClient()
    {
        var baseUrl =
            Environment.GetEnvironmentVariable("DOCLINGSERVE_BASE_URL") is { Length: > 0 } baseUrlValue
                ? baseUrlValue
                : "http://localhost:5001";

        var apiKey =
            Environment.GetEnvironmentVariable("DOCLINGSERVE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : null;

        // Verify server is reachable before running tests
        using var httpClient = new System.Net.Http.HttpClient { Timeout = TimeSpan.FromSeconds(5) };
        try
        {
            httpClient.GetAsync(new Uri(new Uri(baseUrl), "/health")).GetAwaiter().GetResult();
        }
        catch (Exception)
        {
            throw new AssertInconclusiveException(
                $"DoclingServe is not reachable at {baseUrl}. Start a local instance or set DOCLINGSERVE_BASE_URL.");
        }

        return apiKey is not null
            ? new DoclingServeClient(apiKey, baseUri: new Uri(baseUrl))
            : new DoclingServeClient(baseUri: new Uri(baseUrl));
    }
}
