namespace TTools.StatusPageIO.Api.Models.Response;

public class SummaryResponse : BaseResponse
{
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("components")]
    public IList<ComponentModel> Components { get; set; }

    [JsonPropertyName("incidents")]
    public IList<Incident> Incidents { get; set; }

    [JsonPropertyName("scheduled_maintenances")]
    public IList<ScheduledMaintenance> ScheduledMaintenances { get; set; }
}
