using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Shared;

public class LogSummary
{
    [JsonPropertyName("url")] 
    public string Url { get; set; } = "";
    [JsonPropertyName("method")]
    public string Method { get; set; } = "";
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }
}