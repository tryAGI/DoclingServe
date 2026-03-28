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

        return apiKey is not null
            ? new DoclingServeClient(apiKey, baseUri: new Uri(baseUrl))
            : new DoclingServeClient(baseUri: new Uri(baseUrl));
    }
}
