using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing.Requests;

public class GetTicketsRequest
{
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }
    [JsonPropertyName("created_after")]
    public DateTime? CreatedAfter { get; set; }
    [JsonPropertyName("created_before")]
    public DateTime? CreatedBefore { get; set; }
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
    [JsonPropertyName("expand")]
    public string? Expand { get; set; }
    [JsonPropertyName("include_deleted_data")]
    public bool? IncludeDeletedData { get; set; }
    [JsonPropertyName("include_remote_data")]
    public bool? IncludeRemoteData { get; set; }
    [JsonPropertyName("modified_after")]
    public DateTime? ModifiedAfter { get; set; }
    [JsonPropertyName("modified_before")]
    public DateTime? ModifiedBefore { get; set; }
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; set; }
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }
}