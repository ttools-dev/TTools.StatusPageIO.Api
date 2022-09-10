namespace TTools.StatusPageIO.Api.Models.Response;

public record StatusResponse : BaseResponse
{
    [JsonPropertyName("status")]
    public Status Status { get; set; } = null!;
}
