/*
order: 30
title: Management
slug: management

Check server management information and clear cached converters.
*/

namespace DoclingServe.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetMemoryUsage()
    {
        var client = Client;

        //// Retrieve memory usage statistics from the Docling Serve instance.
        //// This is useful for monitoring resource consumption on self-hosted deployments.
        var counts = await client.Management.MemoryCountsV1MemoryCountsGetAsync();

        counts.Should().NotBeNull();

        Console.WriteLine($"Converter count: {counts}");
    }

    [TestMethod]
    public async Task ClearConverters()
    {
        var client = Client;

        //// Clear cached converters from the Docling Serve instance.
        //// This frees up memory by unloading previously loaded conversion pipelines.
        var result = await client.Clear.ClearConvertersV1ClearConvertersGetAsync();

        result.Should().NotBeNull();

        Console.WriteLine($"Clear result: {result}");
    }
}
