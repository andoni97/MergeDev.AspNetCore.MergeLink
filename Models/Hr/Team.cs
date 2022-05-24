using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Hr;

public class Team
{
  [JsonPropertyName("id")] 
  public string Id { get; set; } = "";

  [JsonPropertyName("remote_id")]
  public string RemoteId { get; set; } = "";

  [JsonPropertyName("name")]
  public string Name { get; set; } = "";

  [JsonPropertyName("parent_team")]
  public string ParentId { get; set; } = "";
}