using System.Text.Json.Serialization;

namespace MergeDev.AspNetCore.MergeLink.Models.Ticketing;

public class Attachment
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("remote_id")]
    public string RemoteId { get; set; } = "";

    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = "";

    [JsonPropertyName("ticket")]
    public string Ticket { get; set; } = "";

    [JsonPropertyName("file_url")]
    public string FileUrl { get; set; } = "";

    [JsonPropertyName("content_type")]
    public string ContentType { get; set; } = "";

    [JsonPropertyName("uploaded_by")]
    public string UploadedBy { get; set; } = "";

    [JsonPropertyName("remote_created_at")]
    public DateTime RemoteCreatedAt { get; set; }
}