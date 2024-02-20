namespace Sa.Core.ErrorHandling.Models;

public class ApiErrorResponse
{
    public required string Message { get; set; }
    public required int StatusCode { get; set; }
}