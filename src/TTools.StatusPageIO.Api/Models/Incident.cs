namespace TTools.StatusPageIO.Api.Models;

public class Incident
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

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
    public string Impact { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("page_id")]
    public string PageId { get; set; } = null!;

    [JsonPropertyName("shortlink")]
    public Uri Shortlink { get; set; } = null!;

    // TODO: enum
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonPropertyName("incident_updates")]
    public IList<IncidentUpdate> Updates { get; set; } = null!;
}
