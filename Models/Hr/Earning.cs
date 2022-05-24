using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Earning
{
    [JsonPropertyName("employee_payroll_run")]
    public string EmployeePayrollRun { get; set; } = "";
    [JsonPropertyName("amount")]
    public double Amount { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";
}