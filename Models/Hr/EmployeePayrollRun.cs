using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class EmployeePayrollRun
{
    [JsonPropertyName("HEADERid")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("employee")]
    public string Employee { get; set; } = "";
    [JsonPropertyName("payroll_run")]
    public string PayrollRun { get; set; } = "";
    [JsonPropertyName("gross_pay")]
    public double GrossPay { get; set; }
    [JsonPropertyName("net_pay")]
    public double NetPay { get; set; }
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }
    [JsonPropertyName("end_date")]
    public DateTime EndDate { get; set; }
    [JsonPropertyName("check_date")]
    public DateTime CheckDate { get; set; }
    [JsonPropertyName("earnings")]
    public List<Earning> Earnings { get; set; } = new();
    [JsonPropertyName("deductions")]
    public List<Deduction> Deductions { get; set; } = new();
    [JsonPropertyName("taxes")]
    public List<Tax> Taxes { get; set; } = new();
}