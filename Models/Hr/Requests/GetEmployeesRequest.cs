using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;

public class GetEmployeesRequest
{
    [JsonPropertyName("company_id")]
    public Guid? CompanyId { get; set; }
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
    [JsonPropertyName("include_sensitive_fields")]
    public bool? IncludeSensitiveFields { get; set; }
    [JsonPropertyName("manager_id")]
    public Guid? ManagerId { get; set; }
    [JsonPropertyName("modified_after")]
    public DateTime? ModifiedAfter { get; set; }
    [JsonPropertyName("modified_before")]
    public DateTime? ModifiedBefore { get; set; }
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }
    [JsonPropertyName("pay_group_id")]
    public Guid? PayGroupId { get; set; }
    [JsonPropertyName("personal_email")]
    public string? PersonalEmail { get; set; }
    [JsonPropertyName("remote_id")]
    public Guid? RemoteId { get; set; }
    [JsonPropertyName("team_id")]
    public Guid? TeamId { get; set; }
    [JsonPropertyName("work_email")]
    public string? WorkEmail { get; set; }
    [JsonPropertyName("work_location_id")]
    public Guid? WorkLocationId { get; set; }
}