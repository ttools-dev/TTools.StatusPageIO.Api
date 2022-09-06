namespace TTools.StatusPageIO.Api.Models.Response;

public class StatusResponse : BaseResponse
{
    [JsonPropertyName("status")]
    public Status Status { get; set; }
}
