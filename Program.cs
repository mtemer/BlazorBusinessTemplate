using BlazorBusinessTemplate.Components;
using BlazorBusinessTemplate.Configuration;
using BlazorBusinessTemplate.Core.Abstractions;
using BlazorBusinessTemplate.Extensions;
using BlazorBusinessTemplate.Samples.Todo.Configuration;
using BlazorBusinessTemplate.Samples.Todo.Data;
using BlazorBusinessTemplate.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// Services
// ---------------------------------------------------------

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMTBusinessFramework();

builder.Services.AddSqliteDatabase<TodoDbContext>(
    TodoOptions.ConnectionString);

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
    var fileSystem =
        scope.ServiceProvider.GetRequiredService<FileSystemService>();

    fileSystem.EnsureDirectory(
        FrameworkDefaults.DatabaseFolder);

    var databaseService =
        scope.ServiceProvider.GetRequiredService<IDatabaseService>();

    await databaseService.EnsureCreatedAsync();
}

// ---------------------------------------------------------
// Desktop browser launcher
// ---------------------------------------------------------

if (!app.Environment.IsDevelopment())
{
    var browserLauncher =
        app.Services.GetRequiredService<BrowserLauncherService>();

    browserLauncher.Open(
        FrameworkDefaults.DefaultUrl,
        FrameworkDefaults.BrowserLaunchDelay);
}

// ---------------------------------------------------------
// Run
// ---------------------------------------------------------

app.Run();