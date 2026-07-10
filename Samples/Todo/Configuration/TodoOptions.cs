using BlazorBusinessTemplate.Configuration;

namespace BlazorBusinessTemplate.Samples.Todo.Configuration;

/// <summary>
/// Contains configuration values for the Todo sample application.
/// </summary>
public static class TodoOptions
{
    /// <summary>
    /// Todo sample database file name.
    /// </summary>
    public const string DatabaseFile = "Todo.db";

    /// <summary>
    /// Gets the Todo sample database path.
    /// </summary>
    public static string DatabasePath =>
        Path.Combine(
            FrameworkDefaults.DatabaseFolder,
            DatabaseFile);

    /// <summary>
    /// Gets the Todo sample SQLite connection string.
    /// </summary>
    public static string ConnectionString =>
        $"Data Source={DatabasePath}";
}