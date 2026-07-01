namespace BlazorBusinessTemplate.Configuration;

/// <summary>
/// Contains default values used throughout the application.
/// Centralizing these values avoids magic strings and simplifies maintenance.
/// </summary>
public static class ApplicationDefaults
{
    // ---------------------------------------------------------
    // Application
    // ---------------------------------------------------------

    public const string FrameworkName = "MT Business Framework";
    public const string FrameworkVersion = "1.0.0";

    // ---------------------------------------------------------
    // Database
    // ---------------------------------------------------------

    public const string DatabaseFile = "app.db";

    public static string ConnectionString =>
        $"Data Source={DatabaseFile}";

    // ---------------------------------------------------------
    // Browser
    // ---------------------------------------------------------

    public const string DefaultUrl = "http://localhost:5000";

    public const int BrowserLaunchDelay = 1500;

    // ---------------------------------------------------------
    // Backup
    // ---------------------------------------------------------

    public const string BackupFolder = "Backups";

    // ---------------------------------------------------------
    // Settings
    // ---------------------------------------------------------

    public const string LocalStorageKey = "MTBusinessSettings";
}
