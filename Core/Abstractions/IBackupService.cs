namespace BlazorBusinessTemplate.Core.Abstractions;

/// <summary>
/// Provides backup operations for files.
/// </summary>
public interface IBackupService
{
    /// <summary>
    /// Creates a backup of the specified file.
    /// </summary>
    Task BackupFileAsync(
        string sourceFile,
        string destinationFolder);

    /// <summary>
    /// Restores a file from a backup.
    /// </summary>
    Task RestoreFileAsync(
        string backupFile,
        string destinationFile);
}