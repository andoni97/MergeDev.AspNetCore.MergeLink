using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Employee
{
    [JsonPropertyName("id")] public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }
    [JsonPropertyName("employee_number")]
    public string? EmployeeNumber { get; set; }
    [JsonPropertyName("company")]
    public string? Company { get; set; }
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    [JsonPropertyName("display_full_name")]
    public string? DisplayFullName { get; set; }
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; } = new();
    [JsonPropertyName("work_email")]
    public string? WorkEmail { get; set; }
    [JsonPropertyName("personal_email")]
    public string? PersonalEmail { get; set; }
    [JsonPropertyName("mobile_phone_number")]
    public string? MobilePhoneNumber { get; set; }
    [JsonPropertyName("employments")]
    public List<string> Employments { get; set; } = new();
    [JsonPropertyName("home_location")]
    public string? HomeLocation { get; set; }
    [JsonPropertyName("work_location")]
    public string? WorkLocation { get; set; }
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }
    [JsonPropertyName("team")]
    public string? Team { get; set; }
    [JsonPropertyName("pay_group")]
    public string? PayGroup { get; set; }
    [JsonPropertyName("ssn")]
    public string? Ssn { get; set; }
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    [JsonPropertyName("ethnicity")]
    public string? Ethnicity { get; set; }
    [JsonPropertyName("marital_status")]
    public string? MaritalStatus { get; set; }
    [JsonPropertyName("date_of_birth")]
    public DateTime? DateOfBirth { get; set; }
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("employment_status")]
    public string? EmploymentStatus { get; set; }
    [JsonPropertyName("termination_date")]
    public DateTime? TerminationDate { get; set; }
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }
    // [JsonPropertyName("custom_fields")]
    // public Dictionary<string, object> CustomFields { get; set; } = new();
}