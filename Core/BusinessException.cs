namespace BlazorBusinessTemplate.Core;

/// <summary>
/// BusinessException predstavlja samo iznimku that occurs during business operations.
/// </summary>
public sealed class BusinessException : Exception
{
    public BusinessException(string message)
        : base(message)
    {
    }

    public BusinessException(
        string message,
        Exception innerException)
        : base(message, innerException)
    {
    }
}