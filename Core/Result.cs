namespace BlazorBusinessTemplate.Core;

/// <summary>
/// Represents the result of an operation.
/// </summary>
public class Result
{
    protected Result(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    /// <summary>
    /// Indicates whether the operation completed successfully.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Indicates whether the operation failed.
    /// </summary>
    public bool IsFailure => !IsSuccess;

    /// <summary>
    /// Optional message describing the result.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    public static Result Ok(string message = "")
        => new(true, message);

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    public static Result Fail(string message)
        => new(false, message);
}