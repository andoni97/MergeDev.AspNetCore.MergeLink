using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class PaginatedResponse<T>
{
    [JsonPropertyName("next")]
    public string? Next { get; set; } = "";
    [JsonPropertyName("previous")]
    public string? Previous { get; set; } = "";

    [JsonPropertyName("results")]
    public List<T> Results { get; set; } = new();
}