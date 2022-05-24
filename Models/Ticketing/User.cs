using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class User
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; } = "";

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; } = "";

    [JsonPropertyName("teams")] 
    public List<string> Teams { get; set; } = new();
}