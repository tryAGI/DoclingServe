/*
order: 10
title: Health
slug: health

Check the health, readiness, and version of a Docling Serve instance.
*/

namespace DoclingServe.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CheckHealth()
    {
        using var client = GetAuthenticatedClient();

        //// Check the health status of the Docling Serve instance.
        //// Returns a status string indicating whether the service is operational.
        var health = await client.Health.HealthHealthGetAsync();

        health.Should().NotBeNull();
        health.Status.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Health status: {health.Status}");
    }

    [TestMethod]
    public async Task CheckReadiness()
    {
        using var client = GetAuthenticatedClient();

        //// Check whether the Docling Serve instance is ready to accept requests.
        //// This verifies that all required models and pipelines are loaded.
        var readiness = await client.Health.ReadinessReadyGetAsync();

        readiness.Should().NotBeNull();
        readiness.Status.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Readiness status: {readiness.Status}");
    }

    [TestMethod]
    public async Task GetVersion()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve the version information of the running Docling Serve instance.
        var version = await client.Health.VersionInfoVersionGetAsync();

        version.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Version: {version}");
    }
}
