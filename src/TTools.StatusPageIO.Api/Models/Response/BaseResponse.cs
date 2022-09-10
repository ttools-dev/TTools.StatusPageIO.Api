namespace TTools.StatusPageIO.Api.Models.Response;

public record BaseResponse
{
    [JsonPropertyName("page")]
    public PageInfo Page { get; set; } = null!;
}
