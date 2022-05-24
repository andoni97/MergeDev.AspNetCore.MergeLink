using System.Reflection;
using System.Text.Json.Serialization;
using System.Web;

namespace MergeDev.AspNetCore.MergeLink.Helpers;

public static class QueryParametersBuilder
{
    public static string? ToQueryParams(this object request)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);

        foreach (var property in request.GetType().GetProperties())
        {
            var value = property.GetValue(request);
            if (value is null) continue;
            var nameAttr = property.GetCustomAttribute<JsonPropertyNameAttribute>();
            query[nameAttr?.Name ?? property.Name.ToLower()] = value.ToString();
        }
        
        return query.ToString();
    }
}