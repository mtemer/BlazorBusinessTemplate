namespace BlazorBusinessTemplate.Core;

/// <summary>
/// Represents the result of an operation that returns data.
/// </summary>
public class Result<T> : Result
{
    private Result(
        bool isSuccess,
        T? data,
        string message)
        : base(isSuccess, message)
    {
        Data = data;
    }

    /// <summary>
    /// Gets the returned data.
    /// </summary>
    public T? Data { get; }

    /// <summary>
    /// Creates a successful result with data.
    /// </summary>
    public static Result<T> Ok(
        T data,
        string message = "")
    {
        return new Result<T>(
            true,
            data,
            message);
    }

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    public new static Result<T> Fail(string message)
    {
        return new Result<T>(
            false,
            default,
            message);
    }
}