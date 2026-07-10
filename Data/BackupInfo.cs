namespace BlazorBusinessTemplate.Data;

/// <summary>
/// Represents information about a created backup.
/// </summary>
public sealed class BackupInfo
{
    /// <summary>
    /// Gets the source file.
    /// </summary>
    public string SourceFile { get; init; } = string.Empty;

    /// <summary>
    /// Gets the backup file.
    /// </summary>
    public string BackupFile { get; init; } = string.Empty;

    /// <summary>
    /// Gets the creation time.
    /// </summary>
    public DateTime CreatedOn { get; init; }
}