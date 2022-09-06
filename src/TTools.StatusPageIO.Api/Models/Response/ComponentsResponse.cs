namespace TTools.StatusPageIO.Api.Models.Response;

public class ComponentsResponse : BaseResponse
{
    [JsonPropertyName("components")]
    public IList<ComponentModel> Components { get; set; }
}
