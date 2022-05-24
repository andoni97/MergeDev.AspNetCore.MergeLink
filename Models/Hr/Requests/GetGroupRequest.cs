using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetGroupRequest
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("include_remote_data")]
    public bool? IncludeRemoteData { get; set; }
}