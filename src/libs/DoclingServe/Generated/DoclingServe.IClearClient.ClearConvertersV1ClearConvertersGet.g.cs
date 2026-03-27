#nullable enable

namespace DoclingServe
{
    public partial interface IClearClient
    {
        /// <summary>
        /// Clear Converters
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.ClearResponse> ClearConvertersV1ClearConvertersGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}