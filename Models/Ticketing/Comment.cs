using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class Comment
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = "";

	[JsonPropertyName("remote_id")]
	public string RemoteId { get; set; } = "";

	[JsonPropertyName("author")]
	public string Author { get; set; } = "";

	[JsonPropertyName("body")]
	public string Body { get; set; } = "";

	[JsonPropertyName("ticket")]
	public string Ticket { get; set; } = "";

	[JsonPropertyName("remote_created_at")]
	public DateTime RemoteCreatedAt { get; set; }
}