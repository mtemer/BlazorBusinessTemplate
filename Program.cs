using BlazorBusinessTemplate.Components;
using BlazorBusinessTemplate.Configuration;
using BlazorBusinessTemplate.Services;
using BlazorBusinessTemplate.Extensions;
using BlazorBusinessTemplate.Data;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// Services
// ---------------------------------------------------------

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSqliteDatabase<AppDbContext>(
    ApplicationDefaults.ConnectionString);

builder.Services.AddMTBusinessFramework();

// ---------------------------------------------------------
// Build
// ---------------------------------------------------------

var app = builder.Build();

// ---------------------------------------------------------
// Middleware
// ---------------------------------------------------------

app.UseMTBusinessFramework();

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