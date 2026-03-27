#nullable enable

namespace DoclingServe
{
    public partial interface IManagementClient
    {
        /// <summary>
        /// Memory Stats
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoryStatsV1MemoryStatsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}