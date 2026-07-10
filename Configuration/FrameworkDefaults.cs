namespace BlazorBusinessTemplate.Configuration;

/// <summary>
/// Contains default values used by MT Business Framework.
/// </summary>
public static class FrameworkDefaults
{
    // ---------------------------------------------------------
    // Database
    // ---------------------------------------------------------

    /// <summary>
    /// Default folder for application database files.
    /// </summary>
    public const string DatabaseFolder = "Data";

    // ---------------------------------------------------------
    // Browser
    // ---------------------------------------------------------

    /// <summary>
    /// Default URL used for local desktop execution.
    /// </summary>
    public const string DefaultUrl = "http://localhost:5000";

    /// <summary>
    /// Delay before opening the default browser.
    /// </summary>
    public const int BrowserLaunchDelay = 1500;

    // ---------------------------------------------------------
    // Backup
    // ---------------------------------------------------------

    /// <summary>
    /// Default folder for backup files.
    /// </summary>
    public const string BackupFolder = "Backup";

    // ---------------------------------------------------------
    // Settings
    // ---------------------------------------------------------

    /// <summary>
    /// Default browser localStorage key.
    /// </summary>
    public const string LocalStorageKey = "MTBusinessSettings";
}