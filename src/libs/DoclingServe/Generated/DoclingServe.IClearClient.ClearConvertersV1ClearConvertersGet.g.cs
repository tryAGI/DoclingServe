#nullable enable

namespace DoclingServe
{
    public partial interface IClearClient
    {
        /// <summary>
        /// Clear Converters
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.ClearResponse> ClearConvertersV1ClearConvertersGetAsync(
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear Converters
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.AutoSDKHttpResponse<global::DoclingServe.ClearResponse>> ClearConvertersV1ClearConvertersGetAsResponseAsync(
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}