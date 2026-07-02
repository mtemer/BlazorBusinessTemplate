namespace BlazorBusinessTemplate.Configuration;

/// <summary>
/// Represents database configuration.
/// </summary>
public sealed class DatabaseOptions
{
    /// <summary>
    /// Gets or sets the SQLite connection string.
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the database file name.
    /// </summary>
    public string DatabaseFile { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the backup folder.
    /// </summary>
    public string BackupFolder { get; set; } = string.Empty;
}