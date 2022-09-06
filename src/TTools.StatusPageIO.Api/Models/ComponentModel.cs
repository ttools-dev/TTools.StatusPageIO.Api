namespace TTools.StatusPageIO.Api.Models;

public class ComponentModel
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    // TODO: enum
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("page_id")]
    public string PageId { get; set; } = null!;

}
