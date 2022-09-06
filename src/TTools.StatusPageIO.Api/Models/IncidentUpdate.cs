namespace TTools.StatusPageIO.Api.Models;

public class IncidentUpdate
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("display_at")]
    public DateTimeOffset DisplayAt { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }

    [JsonPropertyName("incident_id")]
    public string IncidentId { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }
}
