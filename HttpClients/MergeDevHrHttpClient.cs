using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using MergeDev.AspNetCore.MergeLink.Helpers;
using MergeDev.AspNetCore.MergeLink.Models.Hr;
using MergeDev.AspNetCore.MergeLink.Models.Hr.Requests;
using MergeDev.AspNetCore.MergeLink.Models.Shared;

namespace MergeDev.AspNetCore.MergeLink.HttpClients;

public class MergeDevHrHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly MergeLinkHttpClient _mergeLinkHttp;
    
    public MergeDevHrHttpClient(HttpClient httpClient, MergeLinkHttpClient mergeLinkHttp)
    {
        _httpClient = httpClient;
        _mergeLinkHttp = mergeLinkHttp;
    }

    public async Task<PaginatedResponse<Employee>?> GetEmployees(string accountToken, GetEmployeesRequest? request = null, CancellationToken ct = default)
    {
        var query = request is null ? string.Empty : request.ToQueryParams();
        
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"employees{query}", UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadAsStringAsync(cancellationToken: ct);
        var res = JsonSerializer.Deserialize<PaginatedResponse<Employee>>(response);

        return res;
    }
    
    public async Task<Employee?> GetEmployee(string accountToken, Guid id, GetEmployeeRequest? request, CancellationToken ct = default)
    {
        var url = $"employees/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        
        var response = await result.Content.ReadFromJsonAsync<Employee>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<ValidationResponse<Employee>?> CreateEmployee(string accountToken, CreateEmployeeRequest request, bool runAsync = false, bool isDebugMode = false, CancellationToken ct = default)
    {
        var url = $"employees?run_async={runAsync}&is_debug_mode={isDebugMode}";
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);
        var message = new HttpRequestMessage(HttpMethod.Post, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            },
            Content = content 
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<ValidationResponse<Employee>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Location>?> GetLocations(string accountToken, GetLocationsRequest request, CancellationToken ct = default)
    {
        var query = request.ToQueryParams();
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"locations{query}"))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Location>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<Location?> GetLocation(string accountToken, Guid id, GetLocationRequest? request, CancellationToken ct = default)
    {
        var url = $"locations/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<Location>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Group>?> GetGroups(string accountToken, GetGroupsRequest request, CancellationToken ct = default)
    {
        var query = request.ToQueryParams();
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"groups{query}"))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Group>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<Group?> GetGroup(string accountToken, Guid id, GetGroupRequest? request, CancellationToken ct = default)
    {
        var url = $"groups/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<Group>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Team>?> GetTeams(string accountToken, GetTeamsRequest request, CancellationToken ct = default)
    {
        var query = request.ToQueryParams();
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"teams{query}"))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Team>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<Team?> GetTeam(string accountToken, Guid id, GetTeamRequest? request, CancellationToken ct = default)
    {
        var url = $"teams/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<Team>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<PaginatedResponse<EmployeePayrollRun>?> GetEmployeePayRollRuns(string accountToken, GetEmployeePayRollRunsRequest request, CancellationToken ct = default)
    {
        var query = request.ToQueryParams();
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"employee-payroll-runs{query}"))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<EmployeePayrollRun>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<EmployeePayrollRun?> GetEmployeePayRollRun(string accountToken, Guid id, GetEmployeePayRollRunRequest? request, CancellationToken ct = default)
    {
        var url = $"employee-payroll-runs/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }
        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<EmployeePayrollRun>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<PaginatedResponse<Employment>?> GetEmployments(string accountToken, GetEmploymentsRequest request, CancellationToken ct = default)
    {
        var query = request.ToQueryParams();

        var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"employments{query}"))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        
        var result = await _httpClient.SendAsync(message, ct);

        var response = await result.Content.ReadFromJsonAsync<PaginatedResponse<Employment>>(cancellationToken: ct);
        
        return response;
    }
    
    public async Task<Employment?> GetEmployment(string accountToken, Guid id, GetEmploymentRequest? request, CancellationToken ct = default)
    {
        var url = $"employments/{id}";
        if (request is not null)
        {
            url += request.ToQueryParams();
        }

        var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative))
        {
            Headers =
            {
                { "X-Account-Token", accountToken }
            }
        };
        var result = await _httpClient.SendAsync(message, ct);
        var response = await result.Content.ReadFromJsonAsync<Employment>(cancellationToken: ct);
        
        return response;
    }
}