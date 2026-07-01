using BlazorBusinessTemplate.Models;

namespace BlazorBusinessTemplate.Core.Abstractions;

/// <summary>
/// Provides access to application settings.
/// </summary>
public interface ISettingsService
{
    Task<AppSettings> LoadAsync();

    Task SaveAsync(AppSettings settings);

    Task ResetAsync();
}