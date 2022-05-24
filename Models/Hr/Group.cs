using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Group
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("parent_group")]
    public string ParentGroup { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";
}