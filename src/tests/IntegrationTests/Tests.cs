namespace DoclingServe.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DoclingServeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DOCLINGSERVE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DOCLINGSERVE_API_KEY environment variable is not found.");

        var client = new DoclingServeClient(apiKey);
        
        return client;
    }
}
