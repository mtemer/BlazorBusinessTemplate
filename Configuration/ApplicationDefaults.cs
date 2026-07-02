public static class ApplicationDefaults
{
    // Database

    public const string DatabaseFolder = "Data";

    public const string DatabaseFile = "Business.db";

    public static string DatabasePath =>
        Path.Combine(DatabaseFolder, DatabaseFile);

    public static string ConnectionString =>
        $"Data Source={DatabasePath}";

    // Browser

    public const string DefaultUrl = "http://localhost:5000";

    public const int BrowserLaunchDelay = 1500;

    // Backup

    public const string BackupFolder = "Backup";

    // Settings

    public const string LocalStorageKey = "MTBusinessSettings";
}