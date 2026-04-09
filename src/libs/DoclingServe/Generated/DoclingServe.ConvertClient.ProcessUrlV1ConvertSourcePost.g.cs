
#nullable enable

namespace DoclingServe
{
    public partial class ConvertClient
    {


        private static readonly global::DoclingServe.EndPointSecurityRequirement s_ProcessUrlV1ConvertSourcePostSecurityRequirement0 =
            new global::DoclingServe.EndPointSecurityRequirement
            {
                Authorizations = new global::DoclingServe.EndPointAuthorizationRequirement[]
                {                    new global::DoclingServe.EndPointAuthorizationRequirement
                    {
                        Type = "",
                        Location = "",
                        Name = "",
                        FriendlyName = "Authorization",
                    },
                },
            };
        private static readonly global::DoclingServe.EndPointSecurityRequirement[] s_ProcessUrlV1ConvertSourcePostSecurityRequirements =
            new global::DoclingServe.EndPointSecurityRequirement[]
            {                s_ProcessUrlV1ConvertSourcePostSecurityRequirement0,
            };
        partial void PrepareProcessUrlV1ConvertSourcePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::DoclingServe.ConvertDocumentsRequest request);
        partial void PrepareProcessUrlV1ConvertSourcePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::DoclingServe.ConvertDocumentsRequest request);
        partial void ProcessProcessUrlV1ConvertSourcePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProcessUrlV1ConvertSourcePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Process Url
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>> ProcessUrlV1ConvertSourcePostAsync(

            global::DoclingServe.ConvertDocumentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProcessUrlV1ConvertSourcePostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::DoclingServe.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ProcessUrlV1ConvertSourcePostSecurityRequirements,
                operationName: "ProcessUrlV1ConvertSourcePostAsync");

            var __pathBuilder = new global::DoclingServe.PathBuilder(
                path: "/v1/convert/source",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareProcessUrlV1ConvertSourcePostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProcessUrlV1ConvertSourcePostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::DoclingServe.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::DoclingServe.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::DoclingServe.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::DoclingServe.ApiException<global::DoclingServe.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessProcessUrlV1ConvertSourcePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::DoclingServe.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::DoclingServe.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Process Url
        /// </summary>
        /// <param name="options">
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </param>
        /// <param name="sources"></param>
        /// <param name="target">
        /// Default Value: {"kind":"inbody"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>> ProcessUrlV1ConvertSourcePostAsync(
            global::System.Collections.Generic.IList<global::DoclingServe.SourcesItem> sources,
            global::DoclingServe.ConvertDocumentsRequestOptions? options = default,
            global::DoclingServe.Target? target = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DoclingServe.ConvertDocumentsRequest
            {
                Options = options,
                Sources = sources,
                Target = target,
            };

            return await ProcessUrlV1ConvertSourcePostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}