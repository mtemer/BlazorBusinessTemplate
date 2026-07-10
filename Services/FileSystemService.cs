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

    /// <summary>
    /// Copies a file.
    /// </summary>
    public void CopyFile(
        string sourceFile,
        string destinationFile,
        bool overwrite = true)
    {
        Guard.NotNullOrWhiteSpace(sourceFile);
        Guard.NotNullOrWhiteSpace(destinationFile);

        File.Copy(sourceFile, destinationFile, overwrite);
    }

    /// <summary>
    /// Deletes a file if it exists.
    /// </summary>
    public void DeleteFile(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    /// <summary>
    /// Moves a file.
    /// </summary>
    public void MoveFile(
        string sourceFile,
        string destinationFile,
        bool overwrite = true)
    {
        Guard.NotNullOrWhiteSpace(sourceFile);
        Guard.NotNullOrWhiteSpace(destinationFile);

        if (overwrite && File.Exists(destinationFile))
        {
            File.Delete(destinationFile);
        }

        File.Move(sourceFile, destinationFile);
    }

    /// <summary>
    /// Returns all files from a directory.
    /// </summary>
    public string[] GetFiles(
        string path,
        string searchPattern = "*.*")
    {
        Guard.NotNullOrWhiteSpace(path);

        return Directory.GetFiles(path, searchPattern);
    }

    /// <summary>
    /// Returns the file name from a path.
    /// </summary>
    public string GetFileName(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return Path.GetFileName(path);
    }

    public string Combine(params string[] paths)
    {
        Guard.NotNull(paths);

        return Path.Combine(paths);
    }

    public string GetFileNameWithoutExtension(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return Path.GetFileNameWithoutExtension(path);
    }

    public string GetExtension(string path)
    {
        Guard.NotNullOrWhiteSpace(path);

        return Path.GetExtension(path);
    }
}