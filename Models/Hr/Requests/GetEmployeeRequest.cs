using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetEmployeeRequest
{
     [JsonPropertyName("expand")]
     public string? Expand { get; set; } = null;
     [JsonPropertyName("include_remote_data")]
     public bool IncludeRemoteData { get; set; } = false;
     [JsonPropertyName("include_sensitive_fields")]
     public bool IncludeSensitiveFields { get; set; } = false;

}