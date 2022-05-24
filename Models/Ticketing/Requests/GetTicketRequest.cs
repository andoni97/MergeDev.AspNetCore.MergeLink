using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing.Requests;

public class GetTicketRequest
{
    [JsonPropertyName("expand")]
    public string? Expand { get; set; }
    [JsonPropertyName("include_remote_data")]
    public bool IncludeRemoteData { get; set; } = false;
}