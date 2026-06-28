namespace BlazorBusinessTemplate.Models;

/// <summary>
/// Represents user-configurable application settings.
/// </summary>
public sealed class AppSettings
{
    public string Theme { get; set; } = "Light";
    public int FontSize { get; set; } = 16;
    public string Language { get; set; } = "hr";
}