using System.Net.Mime;
using System.Text;
using System.Text.Json;
using MergeDev.AspNetCore.MergeLink.Models.Link;

namespace MergeDev.AspNetCore.MergeLink.HttpClients;

public class MergeLinkHttpClient
{
    private readonly HttpClient _httpClient;
    
    public MergeLinkHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> GetLinkToken(string organizationId, string organizationName, string userEmail, IEnumerable<string?> categories, string? integration = null, CancellationToken cancellationToken = default)
    {
        var request = new LinkTokenRequest
        {
            EndUserOriginId = organizationId,
            EndUserOrganizationName = organizationName,
            EndUserEmailAddress = userEmail,
            Categories = categories.ToList(),
            Integration = integration
        };

        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8,
            MediaTypeNames.Application.Json);
        
        var result = await _httpClient.PostAsync($"/api/integrations/create-link-token", content, cancellationToken);

        if (!result.IsSuccessStatusCode) return null;
        
        var body = await result.Content.ReadAsStringAsync(cancellationToken);

        var response = JsonSerializer.Deserialize<Dictionary<string, object>>(body);

        if (response is null) return null;
        
        return response.TryGetValue("link_token", out var token) ? token.ToString() : null;
    }
    
    public async Task<string?> GetAccountToken(string publicToken, CancellationToken cancellationToken = default)
    {
        var result = await _httpClient.GetAsync($"/api/integrations/account-token/{publicToken}", cancellationToken);

        if (!result.IsSuccessStatusCode) return null;
        
        var body = await result.Content.ReadAsStringAsync(cancellationToken);

        var response = JsonSerializer.Deserialize<Dictionary<string, object>>(body);

        if (response is null) return null;
        
        return response.TryGetValue("account_token", out var token) ? token.ToString() : null;
    }
}