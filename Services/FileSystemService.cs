using BlazorBusinessTemplate.Core;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Provides common file system operations.
/// </summary>
public sealed class FileSystemService
{
    /// <summary>
    /// Determines whether the specified file exists.
    /// </summary>
    public bool FileExists(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return File.Exists(path);
    }

    /// <summary>
    /// Determines whether the specified directory exists.
    /// </summary>
    public bool DirectoryExists(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return Directory.Exists(path);
    }

    /// <summary>
    /// Creates the directory if it does not exist.
    /// </summary>
    public void EnsureDirectory(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        Directory.CreateDirectory(path);
    }

    /// <summary>
    /// Gets the file size in bytes.
    /// </summary>
    public long GetFileSize(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return new FileInfo(path).Length;
    }

    /// <summary>
    /// Gets the last write time of the file.
    /// </summary>
    public DateTime GetLastWriteTime(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return File.GetLastWriteTime(path);
    }
}