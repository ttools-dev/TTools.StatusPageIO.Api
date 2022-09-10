using System.Text.Json;
using TTools.StatusPageIO.Api.Models.Response;

namespace TTools.StatusPageIO.Api;

public class StatusPageIoClient : IStatusPageIoClient
{
    private const string SummaryEndpoint = "/api/v2/summary.json";
    private const string StatusEndpoint = "/api/v2/status.json";
    private const string ComponentsEndpoint = "/api/v2/components.json";
    private const string UnresolvedIncidentsEndpoint = "/api/v2/incidents/unresolved.json";
    private const string AllIncidentsEndpoint = "/api/v2/incidents.json";
    private const string UpcomingMaintenancesEndpoint = "/api/v2/scheduled-maintenances/upcoming.json";
    private const string ActiveMaintenancesEndpoint = "/api/v2/scheduled-maintenances/active.json";
    private const string AllMaintenancesEndpoint = "/api/v2/scheduled-maintenances.json";

    private readonly bool _isManagedHttpClient = true;
    private readonly HttpClient _httpClient;

    // ReSharper disable once RedundantDefaultMemberInitializer
    private bool _disposing = false;

    public StatusPageIoClient()
    {
        _isManagedHttpClient = false;
        _httpClient = new HttpClient();
    }

    // TODO: Action to configure
    public StatusPageIoClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <inheritdoc />
    public Task<SummaryResponse?> GetSummaryAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<SummaryResponse>(SummaryEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<StatusResponse?> GetStatusAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<StatusResponse>(StatusEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ComponentsResponse?> GetComponentsAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<ComponentsResponse>(ComponentsEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<IncidentsResponse?> GetUnresolvedIncidentsAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<IncidentsResponse>(UnresolvedIncidentsEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<IncidentsResponse?> GetAllIncidentsAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<IncidentsResponse>(AllIncidentsEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ScheduledMaintenancesResponse?> GetUpcomingMaintenanceAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<ScheduledMaintenancesResponse>(UpcomingMaintenancesEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ScheduledMaintenancesResponse?> GetActiveMaintenanceAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<ScheduledMaintenancesResponse>(ActiveMaintenancesEndpoint, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ScheduledMaintenancesResponse?> GetAllMaintenanceAsync(CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException("The HttpClient task was prematurely cancelled");

        return RequestAndDeserializeEndpointAsync<ScheduledMaintenancesResponse>(AllMaintenancesEndpoint, cancellationToken);
    }

    // ReSharper disable once InconsistentNaming
    private async Task<TResult?> RequestAndDeserializeEndpointAsync<TResult>(string relativePath,
        CancellationToken cancellationToken)
    {
        Stream? responseStream = await _httpClient.GetStreamAsync(relativePath);
        var deserializedResponse = await JsonSerializer.DeserializeAsync<TResult>(
            responseStream, cancellationToken: cancellationToken);

        return deserializedResponse;
    }

    public void Dispose()
    {
        // Should let the underlying DI container dispose of the HttpMessageHandler if we didn't create it
        if (_disposing || _isManagedHttpClient)
            return;

        _disposing = true;
        _httpClient.Dispose();
    }
}
