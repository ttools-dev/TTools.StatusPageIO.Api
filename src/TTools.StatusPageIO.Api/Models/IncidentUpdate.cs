namespace TTools.StatusPageIO.Api.Models;

public record IncidentUpdate
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("display_at")]
    public DateTimeOffset DisplayAt { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    [JsonPropertyName("incident_id")]
    public string IncidentId { get; set; } = null!;

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;
}
