using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBusinessTemplate.Extensions;

/// <summary>
/// Provides database registration extensions.
/// </summary>
public static class DatabaseExtensions
{
    /// <summary>
    /// Registers a SQLite database context factory.
    /// </summary>
    public static IServiceCollection AddSqliteDatabase<TContext>(
        this IServiceCollection services,
        string connectionString)
        where TContext : DbContext
    {
        services.AddDbContextFactory<TContext>(options =>
            options.UseSqlite(connectionString));

        return services;
    }
}