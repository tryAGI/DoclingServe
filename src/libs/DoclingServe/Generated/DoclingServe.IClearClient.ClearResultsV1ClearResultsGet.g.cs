#nullable enable

namespace DoclingServe
{
    public partial interface IClearClient
    {
        /// <summary>
        /// Clear Results
        /// </summary>
        /// <param name="olderThen">
        /// Default Value: 3600
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.ClearResponse> ClearResultsV1ClearResultsGetAsync(
            double? olderThen = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}