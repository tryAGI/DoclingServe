#nullable enable

namespace DoclingServe
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoclingServe.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoclingServe.HealthCheckResponse> HealthHealthGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}