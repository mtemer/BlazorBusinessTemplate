using BlazorBusinessTemplate.Core.Abstractions;
using Microsoft.JSInterop;

namespace BlazorBusinessTemplate.Platform.Storage;

/// <summary>
/// Implements key/value storage using browser localStorage.
/// </summary>
public sealed class BrowserStorage : IKeyValueStorage
{
    private readonly IJSRuntime _js;

    /// <summary>
    /// Creates a new browser storage instance.
    /// </summary>
    public BrowserStorage(IJSRuntime js)
    {
        _js = js;
    }

    /// <inheritdoc />
    public Task<string?> GetAsync(string key)
    {
        return _js.InvokeAsync<string?>(
            "localStorage.getItem",
            key).AsTask();
    }

    /// <inheritdoc />
    public Task SetAsync(string key, string value)
    {
        return _js.InvokeVoidAsync(
            "localStorage.setItem",
            key,
            value).AsTask();
    }

    /// <inheritdoc />
    public Task RemoveAsync(string key)
    {
        return _js.InvokeVoidAsync(
            "localStorage.removeItem",
            key).AsTask();
    }
}