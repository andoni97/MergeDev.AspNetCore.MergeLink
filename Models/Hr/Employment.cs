using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Employment
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("employee")]
    public string Employee { get; set; } = "";
    [JsonPropertyName("job_title")]
    public string JobTitle { get; set; } = "";
    [JsonPropertyName("pay_rate")]
    public string PayRate { get; set; } = "";
    [JsonPropertyName("pay_period")]
    public string PayPeriod { get; set; } = "";
    [JsonPropertyName("pay_frequency")]
    public string PayFrequency { get; set; } = "";
    [JsonPropertyName("pay_currency")]
    public string PayCurrency { get; set; } = "";
    [JsonPropertyName("flsa_status")]
    public string FlsaStatus { get; set; } = "";
    [JsonPropertyName("effective_date")]
    public DateTime EffectiveDate { get; set; }
    [JsonPropertyName("employment_type")]
    public string EmploymentType { get; set; } = "";
}