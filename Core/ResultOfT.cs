namespace BlazorBusinessTemplate.Core;

/// <summary>
/// Represents the result of an operation that returns a value.
/// </summary>
public class Result<T> : Result
{
    private Result(bool isSuccess, T? value, string message)
        : base(isSuccess, message)
    {
        Value = value;
    }

    public T? Value { get; }

    public static Result<T> Ok(T value, string message = "")
        => new(true, value, message);

    public new static Result<T> Fail(string message)
        => new(false, default, message);
}