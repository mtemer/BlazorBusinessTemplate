using BlazorBusinessTemplate.Core;
using BlazorBusinessTemplate.Core.Abstractions;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Provides file backup operations.
/// </summary>
public sealed class BackupService : IBackupService
{
    private readonly FileSystemService _files;

    /// <summary>
    /// Creates a new backup service.
    /// </summary>
    public BackupService(FileSystemService files)
    {
        _files = files;
    }

    /// <inheritdoc />
    public Task<string> BackupFileAsync(
        string sourceFile,
        string destinationFolder)
    {
        Guard.NotNullOrWhiteSpace(sourceFile);
        Guard.NotNullOrWhiteSpace(destinationFolder);

        _files.EnsureDirectory(destinationFolder);

        var backupFile = _files.Combine(
            destinationFolder,
            $"{Path.GetFileNameWithoutExtension(sourceFile)}_{DateTime.Now:yyyyMMdd_HHmmss}{Path.GetExtension(sourceFile)}");

        _files.CopyFile(
            sourceFile,
            backupFile,
            overwrite: true);

        return Task.FromResult(backupFile);
    }

    /// <inheritdoc />
    public Task RestoreFileAsync(
        string backupFile,
        string destinationFile)
    {
        Guard.NotNullOrWhiteSpace(backupFile);
        Guard.NotNullOrWhiteSpace(destinationFile);

        _files.CopyFile(
            backupFile,
            destinationFile,
            overwrite: true);

        return Task.CompletedTask;
    }
}