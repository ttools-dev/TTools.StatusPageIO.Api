using TTools.StatusPageIO.Api.Models;
using TTools.StatusPageIO.Api.Models.Response;

namespace TTools.StatusPageIO.Api;

public interface IStatusPageIoClient : IDisposable
{
    #region Summary

    /// <summary>
    /// Gets the status page's summary for a site
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<SummaryResponse?> GetSummaryAsync(CancellationToken cancellationToken);

    #endregion

    #region Status

    /// <summary>
    /// Gets the rollup of the site's current status
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<StatusResponse?> GetStatusAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Lists the components of a site with their respective status
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<ComponentsResponse?> GetComponentsAsync(CancellationToken cancellationToken);

    #endregion

    #region Incidents

    /// <summary>
    /// Lists unresolved incidents of a site
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<IncidentsResponse?> GetUnresolvedIncidentsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Lists all past incidents of a site (max. 50)
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<IncidentsResponse?> GetAllIncidentsAsync(CancellationToken cancellationToken);

    #endregion

    #region Maintenance

    /// <summary>
    /// Gets upcoming maintenance windows for a site
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<ScheduledMaintenancesResponse?> GetUpcomingMaintenanceAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Gets currently active maintenance for a site
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<ScheduledMaintenancesResponse?> GetActiveMaintenanceAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Gets upcoming maintenance windows for the site
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to stop the request</param>
    /// <returns>TODO</returns>
    Task<ScheduledMaintenancesResponse?> GetAllMaintenanceAsync(CancellationToken cancellationToken);

    #endregion
}
