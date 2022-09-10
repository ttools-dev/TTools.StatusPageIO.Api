namespace TTools.StatusPageIO.Api.Models;

public record ScheduledMaintenance : Incident
{
    [JsonPropertyName("scheduled_for")]
    public DateTimeOffset ScheduledFor { get; set; }

    [JsonPropertyName("scheduled_until")]
    public DateTimeOffset ScheduledUntil { get; set; }
}
