using System.Numerics;
using System.Runtime.CompilerServices;

namespace BlazorBusinessTemplate.Core;

/// <summary>
/// Provides common argument validation methods.
/// </summary>
public static class Guard
{
    /// <summary>
    /// Throws an exception if the value is null.
    /// </summary>
    public static void NotNull<T>(
        T? value,
        [CallerArgumentExpression(nameof(value))]
        string? parameterName = null)
        where T : class
    {
        if (value is null)
        {
            throw new ArgumentNullException(parameterName);
        }
    }

    /// <summary>
    /// Throws an exception if the string is null or white space.
    /// </summary>
    public static void NotNullOrWhiteSpace(
        string? value,
        [CallerArgumentExpression(nameof(value))]
        string? parameterName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(
                "Value cannot be null, empty, or white space.",
                parameterName);
        }
    }

    /// <summary>
    /// Throws an exception if the value is negative.
    /// </summary>
    public static void NotNegative<T>(
        T value,
        [CallerArgumentExpression(nameof(value))]
        string? parameterName = null)
        where T : INumber<T>
    {
        if (value < T.Zero)
        {
            throw new ArgumentOutOfRangeException(parameterName);
        }
    }
}