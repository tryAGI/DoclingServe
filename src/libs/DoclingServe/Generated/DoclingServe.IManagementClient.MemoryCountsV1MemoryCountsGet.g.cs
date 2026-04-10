#nullable enable

namespace DoclingServe
{
    public partial interface IManagementClient
    {
        /// <summary>
        /// Memory Counts
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoryCountsV1MemoryCountsGetAsync(
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}