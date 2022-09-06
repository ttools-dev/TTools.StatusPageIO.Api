namespace TTools.StatusPageIO.Api.Models;

public class Status
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    // TODO: enum
    // none, minor, major, or critical
    [JsonPropertyName("indicator")]
    public string Indicator { get; set; }
}
