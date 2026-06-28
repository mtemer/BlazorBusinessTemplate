using System.Diagnostics;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Opens the default browser for local desktop execution.
/// Intended for published local Blazor applications.
/// </summary>
public sealed class BrowserLauncherService
{
    public void Open(string url, int delayMilliseconds = 1500)
    {
        _ = Task.Run(async () =>
        {
            await Task.Delay(delayMilliseconds);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                // Browser launch is optional. The app must continue running.
            }
        });
    }
}
