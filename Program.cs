using BlazorBusinessTemplate.Components;
using BlazorBusinessTemplate.Infrastructure;
using BlazorBusinessTemplate.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// Services
// ---------------------------------------------------------

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<BrowserLauncherService>();

// ---------------------------------------------------------
// Build
// ---------------------------------------------------------

var app = builder.Build();

// ---------------------------------------------------------
// Middleware
// ---------------------------------------------------------

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// ---------------------------------------------------------
// Desktop launcher
// ---------------------------------------------------------

if (!app.Environment.IsDevelopment())
{
    var browserLauncher =
        app.Services.GetRequiredService<BrowserLauncherService>();

    browserLauncher.Open(
        ApplicationDefaults.DefaultUrl,
        ApplicationDefaults.BrowserLaunchDelay);
}

// ---------------------------------------------------------
// Run
// ---------------------------------------------------------

app.Run();