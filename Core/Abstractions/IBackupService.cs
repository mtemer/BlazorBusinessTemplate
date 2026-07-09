namespace BlazorBusinessTemplate.Core.Abstractions;

/// <summary>
/// Provides backup operations.
/// </summary>
public interface IBackupService
{
    /// <summary>
    /// Creates a timestamped backup copy of a file.
    /// </summary>
    Task<string> BackupFileAsync(
        string sourceFile,
        string destinationFolder);

    /// <summary>
    /// Restores a file from backup.
    /// </summary>
    Task RestoreFileAsync(
        string backupFile,
        string destinationFile);
}