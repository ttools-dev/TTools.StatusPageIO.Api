namespace TTools.StatusPageIO.Api.Models.Response;

public class BaseResponse
{
    [JsonPropertyName("page")]
    public PageInfo Page { get; set; }
}
