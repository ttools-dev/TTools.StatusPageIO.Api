namespace TTools.StatusPageIO.Api.Models.Response;

public class ScheduledMaintenancesResponse : BaseResponse
{
    [JsonPropertyName("scheduled_maintenances")]
    public IList<ScheduledMaintenance> ScheduledMaintenances { get; set; } = null!;
}
