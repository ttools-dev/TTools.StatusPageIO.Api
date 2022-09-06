namespace TTools.StatusPageIO.Api.Models.Response;

public class IncidentsResponse : BaseResponse
{
    [JsonPropertyName("incidents")]
    public IList<Incident> Incidents { get; set; }
}
