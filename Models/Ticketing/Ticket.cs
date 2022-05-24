using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class Ticket
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("assignees")]
    public List<string> Assignees { get; set; } = new();
    [JsonPropertyName("due_date")]
    public DateTime DueDate { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; } = "";
    [JsonPropertyName("description")]
    public string Description { get; set; } = "";
    [JsonPropertyName("project")]
    public string Project { get; set; } = "";
    [JsonPropertyName("ticket_type")]
    public string TicketType { get; set; } = "";
    [JsonPropertyName("account")]
    public string Account { get; set; } = "";
    [JsonPropertyName("attachments")]
    public List<string> Attachments { get; set; } = new();
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; } = new();
    [JsonPropertyName("remote_created_at")]
    public DateTime RemoteCreatedAt { get; set; }
    [JsonPropertyName("remote_updated_at")]
    public DateTime RemoteUpdatedAt { get; set; }
}