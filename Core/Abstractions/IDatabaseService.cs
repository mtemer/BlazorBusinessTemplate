namespace BlazorBusinessTemplate.Core.Abstractions;

/// <summary>
/// Provides database management operations.
/// </summary>
public interface IDatabaseService
{
    /// <summary>
    /// Ensures that the database exists.
    /// </summary>
    Task EnsureCreatedAsync();

    /// <summary>
    /// Applies all pending database migrations.
    /// </summary>
    Task MigrateAsync();
}