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
        global::System.Threading.Tasks.Task<byte[]> TaskResultV1ResultTaskIdGetAsBytesAsync(
            string taskId,
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Task Result
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> TaskResultV1ResultTaskIdGetAsBytesAsStreamAsync(
            string taskId,
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Task Result
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.AutoSDKHttpResponse<byte[]>> TaskResultV1ResultTaskIdGetAsBytesAsResponseAsync(
            string taskId,
            global::DoclingServe.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}