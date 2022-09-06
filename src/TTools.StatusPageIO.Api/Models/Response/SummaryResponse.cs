namespace TTools.StatusPageIO.Api.Models.Response;

public class SummaryResponse : BaseResponse
{
    [JsonPropertyName("status")]
    public Status Status { get; set; } = null!;

    [JsonPropertyName("components")]
    public IList<ComponentModel> Components { get; set; } = null!;

    [JsonPropertyName("incidents")]
    public IList<Incident> Incidents { get; set; } = null!;

    [JsonPropertyName("scheduled_maintenances")]
    public IList<ScheduledMaintenance> ScheduledMaintenances { get; set; } = null!;
}
