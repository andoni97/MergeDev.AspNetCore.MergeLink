using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetEmployeePayRollRunRequest
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("include_remote_data")]
    public bool? IncludeRemoteData { get; set; }
    [JsonPropertyName("expand")]
    public bool? Expand { get; set; }
}