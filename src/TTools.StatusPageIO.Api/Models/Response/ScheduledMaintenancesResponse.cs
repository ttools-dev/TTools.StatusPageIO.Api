namespace TTools.StatusPageIO.Api.Models.Response;

public record ScheduledMaintenancesResponse : BaseResponse
{
    [JsonPropertyName("scheduled_maintenances")]
    public IList<ScheduledMaintenance> ScheduledMaintenances { get; set; } = null!;
}
