using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Company
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("legal_name")]
    public string LegalName { get; set; } = "";
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = "";
    [JsonPropertyName("eins")]
    public List<string> Eins { get; set; } = new();
}