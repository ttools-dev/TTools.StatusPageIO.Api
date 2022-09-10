namespace TTools.StatusPageIO.Api.Models;

public record Status
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    // TODO: enum
    // none, minor, major, or critical
    [JsonPropertyName("indicator")]
    public string Indicator { get; set; } = null!;
}
