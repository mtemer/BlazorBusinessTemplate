namespace BlazorBusinessTemplate.Core.Abstractions;

/// <summary>
/// Provides simple asynchronous key/value storage.
/// </summary>
public interface IKeyValueStorage
{
    /// <summary>
    /// Gets a value by key.
    /// </summary>
    Task<string?> GetAsync(string key);

    /// <summary>
    /// Saves a value by key.
    /// </summary>
    Task SetAsync(string key, string value);

    /// <summary>
    /// Removes a value by key.
    /// </summary>
    Task RemoveAsync(string key);
}