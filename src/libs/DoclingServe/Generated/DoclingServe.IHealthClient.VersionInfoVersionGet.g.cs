#nullable enable

namespace DoclingServe
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Version Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VersionInfoVersionGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}