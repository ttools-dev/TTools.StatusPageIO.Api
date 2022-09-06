namespace TTools.StatusPageIO.Api.Models;

public class Incident
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("monitoring_at")]
    public DateTimeOffset? MonitoringAt { get; set; }

    [JsonPropertyName("resolved_at")]
    public DateTimeOffset? ResolvedAt { get; set; }

    // TODO: enum??
    [JsonPropertyName("impact")]
    public string Impact { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("page_id")]
    public string PageId { get; set; }

    [JsonPropertyName("shortlink")]
    public Uri Shortlink { get; set; }

    // TODO: enum
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("incident_updates")]
    public IList<IncidentUpdate> Updates { get; set; }
}
