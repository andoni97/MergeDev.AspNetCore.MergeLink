using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class Role
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("role_type")]
    public string RoleType { get; set; } = "";
}