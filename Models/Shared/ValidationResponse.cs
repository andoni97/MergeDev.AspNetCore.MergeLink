namespace MergeDev.AspNetCore.MergeLink.Models.Shared;

public class ValidationResponse<T>
{
    public T? Model { get; set; }
    public List<Warning> Warnings { get; set; } = new();
    public List<Error> Errors { get; set; } = new();
    public List<Log> Logs { get; set; } = new();
}