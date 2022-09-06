namespace TTools.StatusPageIO.Api.Models;

public class PageInfo
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("url")]
    public Uri Url { get; set; } = null!;

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
}
