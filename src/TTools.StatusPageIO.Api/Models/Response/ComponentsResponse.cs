namespace TTools.StatusPageIO.Api.Models.Response;

public record ComponentsResponse : BaseResponse
{
    [JsonPropertyName("components")]
    public IList<ComponentModel> Components { get; set; } = null!;
}
