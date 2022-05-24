using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Shared;

public class Log
{
    [JsonPropertyName("log_id")]
    public string LogId { get; set; } = "";
    [JsonPropertyName("dashboard_view")]
    public string DashboardView { get; set; } = "";
    [JsonPropertyName("log_summary")]
    public LogSummary LogSummary { get; set; } = new();
}