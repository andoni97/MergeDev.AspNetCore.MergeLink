using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetTeamRequest
{
    [JsonPropertyName("expand")]
    public string? Expand { get; set; } = null;
    [JsonPropertyName("include_remote_data")]
    public bool IncludeRemoteData { get; set; } = false;
    [JsonPropertyName("include_remote_data")]
    public string? IncludeSensitiveFields { get; set; } = null;
}