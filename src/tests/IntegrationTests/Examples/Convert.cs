/*
order: 20
title: Convert
slug: convert

Convert documents from URLs or files using Docling Serve.
*/

namespace DoclingServe.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ConvertFromUrl()
    {
        var client = Client;

        //// Convert a document from a public URL to Markdown format.
        //// Docling Serve supports PDF, DOCX, PPTX, HTML, images, and many other formats.
        //// The source is specified as an HTTP source with a URL.
        var response = await client.Convert.ProcessUrlV1ConvertSourcePostAsync(
            sources:
            [
                new HttpSourceRequest
                {
                    Url = "https://arxiv.org/pdf/2408.09869",
                    Kind = "http",
                },
            ]);

        response.Should().NotBeNull();

        Console.WriteLine($"Conversion completed. Response: {response}");
    }

    [TestMethod]
    public async Task ConvertFromUrlWithOptions()
    {
        var client = Client;

        //// Convert a document with custom options.
        //// You can specify output formats, enable/disable OCR,
        //// choose the PDF backend, and control table extraction behavior.
        var response = await client.Convert.ProcessUrlV1ConvertSourcePostAsync(
            sources:
            [
                new HttpSourceRequest
                {
                    Url = "https://arxiv.org/pdf/2408.09869",
                    Kind = "http",
                },
            ],
            options: new ConvertDocumentsRequestOptions
            {
                DoOcr = true,
                TableMode = TableFormerMode.Accurate,
            });

        response.Should().NotBeNull();

        Console.WriteLine($"Conversion with options completed. Response: {response}");
    }
}
