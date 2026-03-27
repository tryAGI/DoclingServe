#nullable enable

namespace DoclingServe
{
    public partial interface IManagementClient
    {
        /// <summary>
        /// Memory Counts
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoryCountsV1MemoryCountsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}