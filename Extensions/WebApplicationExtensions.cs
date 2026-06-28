using BlazorBusinessTemplate.Components;
using Microsoft.AspNetCore.Builder;

namespace BlazorBusinessTemplate.Extensions;

/// <summary>
/// Extension methods for configuring the MT Business Framework pipeline.
/// </summary>
public static class WebApplicationExtensions
{
    /// <summary>
    /// Configures the HTTP request pipeline.
    /// </summary>
    public static WebApplication UseMTBusinessFramework(
        this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            app.UseHsts();
        }

        app.UseStatusCodePagesWithReExecute(
            "/not-found",
            createScopeForStatusCodePages: true);

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        return app;
    }
}