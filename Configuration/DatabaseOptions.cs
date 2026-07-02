namespace BlazorBusinessTemplate.Configuration;

/// <summary>
/// Represents database configuration.
/// </summary>
public sealed class DatabaseOptions
{
    /// <summary>
    /// Gets or sets the SQLite database file path.
    /// </summary>
    public string DatabasePath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the backup folder.
    /// </summary>
    public string BackupFolder { get; set; } = string.Empty;
}