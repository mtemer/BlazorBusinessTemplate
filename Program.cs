using BlazorBusinessTemplate.Components;
using BlazorBusinessTemplate.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<BrowserLauncherService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

if (!app.Environment.IsDevelopment())
{
    var browserLauncher =
        app.Services.GetRequiredService<BrowserLauncherService>();

    browserLauncher.Open("http://localhost:5000");
}

app.Run();
