namespace BlazorBusinessTemplate.Models;

/// <summary>
/// Represents database information.
/// </summary>
public sealed class DatabaseInfo
{
    public string Provider { get; set; } = string.Empty;

    public bool Exists { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string Version { get; set; } = string.Empty;
}