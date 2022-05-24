using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Tax
{
    [JsonPropertyName("employee_payroll_run")]
    public string EmployeePayrollRun { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("amount")]
    public double Amount { get; set; }
    [JsonPropertyName("employer_tax")]
    public string EmployerTax { get; set; } = "";
}