using System.Net.Http.Headers;
using MergeDev.AspNetCore.MergeLink.HttpClients;
using Microsoft.Extensions.DependencyInjection;

namespace MergeDev.AspNetCore.MergeLink;

public static class MergeDevExtensionMethods
{
    public static IServiceCollection AddMergeDevHrClient(this IServiceCollection services, string token)
    {
        services.AddHttpClient<MergeDevHrHttpClient>(opts =>
        {
            opts.BaseAddress = new Uri("https://api.merge.dev/api/hris/v1/");
            opts.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        });
        return services;
    }
    
    public static IServiceCollection AddMergeDevTicketingClient(this IServiceCollection services, string token)
    {
        services.AddHttpClient<MergeDevTicketingHttpClient>(opts =>
        {
            opts.BaseAddress = new Uri("https://api.merge.dev/api/ticketing/v1/");
            opts.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        });
        return services;
    }
    
    public static IServiceCollection AddMergeDevLinkClient(this IServiceCollection services, string token)
    {
        services.AddHttpClient<MergeLinkHttpClient>(opts =>
        {
            opts.BaseAddress = new Uri("https://api.merge.dev");
            opts.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        });
        return services;
    }
}