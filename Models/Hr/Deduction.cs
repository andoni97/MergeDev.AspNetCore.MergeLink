using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Deduction
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("employee_payroll_run")]
    public string EmployeePayrollRun { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("employee_deduction")]
    public double EmployeeDeduction { get; set; }
    [JsonPropertyName("company_deduction")]
    public double CompanyDeduction { get; set; }
}