namespace TTools.StatusPageIO.Api.Models.Response;

public record IncidentsResponse : BaseResponse
{
    [JsonPropertyName("incidents")]
    public IList<Incident> Incidents { get; set; } = null!;
}
