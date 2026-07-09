using BlazorBusinessTemplate.Core;
using BlazorBusinessTemplate.Core.Abstractions;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Provides file backup operations.
/// </summary>
public sealed class BackupService : IBackupService
{
    private readonly FileSystemService _files;

    public BackupService(
        FileSystemService files)
    {
        _files = files;
    }

    public Task BackupFileAsync(
        string sourceFile,
        string destinationFolder)
    {
        Guard.NotNullOrWhiteSpace(sourceFile);
        Guard.NotNullOrWhiteSpace(destinationFolder);

        _files.EnsureDirectory(destinationFolder);

        var backupFile =
            Path.Combine(
                destinationFolder,
                $"{Path.GetFileNameWithoutExtension(sourceFile)}_" +
                $"{DateTime.Now:yyyyMMdd_HHmmss}" +
                $"{Path.GetExtension(sourceFile)}");

        File.Copy(sourceFile, backupFile, true);

        return Task.CompletedTask;
    }

    public Task RestoreFileAsync(
        string backupFile,
        string destinationFile)
    {
        Guard.NotNullOrWhiteSpace(backupFile);
        Guard.NotNullOrWhiteSpace(destinationFile);

        File.Copy(backupFile, destinationFile, true);

        return Task.CompletedTask;
    }
}