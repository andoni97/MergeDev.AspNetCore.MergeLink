using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetLocationRequest
{
    [JsonPropertyName("include_remote_data")]
    public bool IncludeRemoteData { get; set; }
}