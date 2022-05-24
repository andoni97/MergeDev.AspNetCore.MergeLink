using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class BankInfo
{
    [JsonPropertyName("id")] 
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("employee")]
    public string Employee { get; set; } = "";
    [JsonPropertyName("account_number")]
    public string AccountNumber { get; set; } = "";
    [JsonPropertyName("routing_number")]
    public string RoutingNumber { get; set; } = "";
    [JsonPropertyName("bank_name")]
    public string BankName { get; set; } = "";
    [JsonPropertyName("account_type")]
    public string AccountType { get; set; } = "";
    [JsonPropertyName("remote_created_at")]
    public DateTime RemoteCreatedAt { get; set; }
}