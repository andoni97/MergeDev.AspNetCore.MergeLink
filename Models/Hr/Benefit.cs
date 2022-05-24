using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Benefit
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("employee")]
    public string Employee { get; set; } = "";
    [JsonPropertyName("provider_name")]
    public string ProviderName { get; set; } = "";
    [JsonPropertyName("benefit_plan_type")]
    public string BenefitPlanType { get; set; } = "";
    [JsonPropertyName("employee_contribution")]
    public double EmployeeContribution { get; set; }
    [JsonPropertyName("company_contribution")]
    public int CompanyContribution { get; set; }
}