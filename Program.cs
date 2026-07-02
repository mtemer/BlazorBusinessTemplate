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

using (var scope = app.Services.CreateScope())
{
    var databaseService =
        scope.ServiceProvider.GetRequiredService<IDatabaseService>();

    await databaseService.MigrateAsync();
}

// ---------------------------------------------------------
// Run
// ---------------------------------------------------------

app.Run();