using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Shared;

public class Warning
{
    [JsonPropertyName("source")]
    public Source Source { get; set; } = new();
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";
    [JsonPropertyName("detail")]
    public string Detail { get; set; } = "";
    [JsonPropertyName("problem_type")]
    public string ProblemType { get; set; } = "";
}