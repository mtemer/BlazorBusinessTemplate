using BlazorBusinessTemplate.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBusinessTemplate.Extensions;


/// <summary>
/// Registers MT Business Framework services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers all framework services.
    /// </summary>
    public static IServiceCollection AddMTBusinessFramework(
        this IServiceCollection services)
    {
        services.AddSingleton<BrowserLauncherService>();
        services.AddScoped<SettingsService>();
        services.AddScoped<LocalStorageService>();
        services.AddSingleton<FileSystemService>();

        return services;
    }
}