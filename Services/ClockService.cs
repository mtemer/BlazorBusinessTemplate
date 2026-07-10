namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Provides the current date and time.
/// </summary>
public sealed class ClockService
{
    /// <summary>
    /// Gets the current local time.
    /// </summary>
    public DateTime Now => DateTime.Now;
}