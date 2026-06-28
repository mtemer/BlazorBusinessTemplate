using System.Text.Json;
using BlazorBusinessTemplate.Infrastructure;
using BlazorBusinessTemplate.Models;
using Microsoft.JSInterop;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Loads and saves application settings using browser localStorage.
/// </summary>
public sealed class SettingsService
{
    private readonly IJSRuntime _js;

    public SettingsService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<AppSettings> LoadAsync()
    {
        var json = await _js.InvokeAsync<string>(
            "localStorage.getItem",
            ApplicationDefaults.LocalStorageKey);

        if (string.IsNullOrWhiteSpace(json))
        {
            return new AppSettings();
        }

        try
        {
            return JsonSerializer.Deserialize<AppSettings>(json)
                   ?? new AppSettings();
        }
        catch
        {
            return new AppSettings();
        }
    }

    public async Task SaveAsync(AppSettings settings)
    {
        var json = JsonSerializer.Serialize(settings);

        await _js.InvokeVoidAsync(
            "localStorage.setItem",
            ApplicationDefaults.LocalStorageKey,
            json);
    }

    public async Task ResetAsync()
    {
        await _js.InvokeVoidAsync(
            "localStorage.removeItem",
            ApplicationDefaults.LocalStorageKey);
    }
}