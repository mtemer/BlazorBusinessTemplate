namespace BlazorBusinessTemplate.Platform.Storage;

/// <summary>
/// Provides simple key/value storage.
/// </summary>
public interface IKeyValueStorage
{
    Task<string?> GetAsync(string key);

    Task SetAsync(string key, string value);

    Task RemoveAsync(string key);
}