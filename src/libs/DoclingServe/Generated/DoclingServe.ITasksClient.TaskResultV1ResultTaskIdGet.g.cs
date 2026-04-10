#nullable enable

namespace DoclingServe
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Task Result
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>> TaskResultV1ResultTaskIdGetAsync(
            string taskId,
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}