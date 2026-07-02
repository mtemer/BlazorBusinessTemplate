using BlazorBusinessTemplate.Components;
using BlazorBusinessTemplate.Configuration;
using BlazorBusinessTemplate.Core.Abstractions;
using BlazorBusinessTemplate.Data;
using BlazorBusinessTemplate.Extensions;
using BlazorBusinessTemplate.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// Services
// ---------------------------------------------------------

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMTBusinessFramework();

builder.Services.AddSqliteDatabase<AppDbContext>(
    ApplicationDefaults.ConnectionString);

// ---------------------------------------------------------
// Build
// ---------------------------------------------------------

var app = builder.Build();

// ---------------------------------------------------------
// Middleware
// ---------------------------------------------------------

app.UseMTBusinessFramework();

// ---------------------------------------------------------
// Database
// ---------------------------------------------------------

using (var scope = app.Services.CreateScope())
{
    var databaseService =
        scope.ServiceProvider.GetRequiredService<IDatabaseService>();

    await databaseService.MigrateAsync();
}

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