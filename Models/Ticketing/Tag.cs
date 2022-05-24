using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class Tag
{
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";

    [JsonPropertyName("name")] 
    public string Name { get; set; } = "";
}