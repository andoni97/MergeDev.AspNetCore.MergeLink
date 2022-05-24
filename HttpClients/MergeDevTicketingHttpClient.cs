using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using MergeDev.AspNetCore.MergeLink.Helpers;
using MergeDev.AspNetCore.MergeLink.Models.Hr;
using MergeDev.AspNetCore.MergeLink.Models.Shared;
using MergeDev.AspNetCore.MergeLink.Models.Ticketing;
using MergeDev.AspNetCore.MergeLink.Models.Ticketing.Requests;

namespace MergeDev.AspNetCore.MergeLink.HttpClients;

public class MergeDevTicketingHttpClient
{
    private readonly HttpClient _httpClient;

    public MergeDevTicketingHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PaginatedResponse<Ticket>?> GetTickets(GetTicketsRequest request, CancellationToken token = default)
    {
        var query = request.ToQueryParams();
        var result = await _httpClient.GetAsync($"tickets{query}", token);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Ticket>>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<Ticket?> GetTicket(Guid id, GetTicketRequest? request, CancellationToken token = default)
    {
        var url = $"tickets/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var result = await _httpClient.GetAsync(url, token);
        var response = await result.Content.ReadFromJsonAsync<Ticket>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<ValidationResponse<Ticket>?> CreateTicket(CreateTicketRequest request, bool runAsync = false, bool isDebugMode = false, CancellationToken token = default)
    {
        var url = $"tickets?run_async={runAsync}&is_debug_mode={isDebugMode}";
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);
        var result = await _httpClient.PostAsync(url, content, token);
        var response = await result.Content.ReadFromJsonAsync<ValidationResponse<Ticket>>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Attachment>?> GetAttachments(GetAttachmentsRequest request, CancellationToken token = default)
    {
        var query = request.ToQueryParams();
        var result = await _httpClient.GetAsync($"attachments{query}", token);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Attachment>>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<Attachment?> GetAttachment(Guid id, GetAttachmentRequest? request, CancellationToken token = default)
    {
        var url = $"attachments/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var result = await _httpClient.GetAsync(url, token);
        var response = await result.Content.ReadFromJsonAsync<Attachment>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<ValidationResponse<Attachment>?> CreateAttachment(CreateAttachmentRequest request, bool runAsync = false, bool isDebugMode = false, CancellationToken token = default)
    {
        var url = $"attachments?run_async={runAsync}&is_debug_mode={isDebugMode}";
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);
        var result = await _httpClient.PostAsync(url, content, token);
        var response = await result.Content.ReadFromJsonAsync<ValidationResponse<Attachment>>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Comment>?> GetComments(GetCommentsRequest request, CancellationToken token = default)
    {
        var query = request.ToQueryParams();
        var result = await _httpClient.GetAsync($"comments{query}", token);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Comment>>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<Comment?> GetComment(Guid id, GetCommentRequest? request, CancellationToken token = default)
    {
        var url = $"comments/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var result = await _httpClient.GetAsync(url, token);
        var response = await result.Content.ReadFromJsonAsync<Comment>(cancellationToken: token);
        
        return response;
    }
    
    public async Task<ValidationResponse<Comment>?> CreateComment(CreateCommentRequest request, bool runAsync = false, bool isDebugMode = false, CancellationToken token = default)
    {
        var url = $"comments?run_async={runAsync}&is_debug_mode={isDebugMode}";
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);
        var result = await _httpClient.PostAsync(url, content, token);
        var response = await result.Content.ReadFromJsonAsync<ValidationResponse<Comment>>(cancellationToken: token);
        
        return response;
    }
}