using BlazorBusinessTemplate.Core;
using BlazorBusinessTemplate.Core.Abstractions;
using BlazorBusinessTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Services;

/// <summary>
/// Provides database management services.
/// </summary>
public sealed class DatabaseService<TContext> : IDatabaseService
    where TContext : DbContext
{
    private readonly IDbContextFactory<TContext> _factory;

    /// <summary>
    /// Creates a new database service.
    /// </summary>
    public DatabaseService(IDbContextFactory<TContext> factory)
    {
        _factory = factory;
    }

    /// <inheritdoc />
    public async Task EnsureCreatedAsync()
    {
        await using var db =
            await _factory.CreateDbContextAsync();

        await db.Database.EnsureCreatedAsync();
    }

    /// <inheritdoc />
    public async Task MigrateAsync()
    {
        await using var db =
            await _factory.CreateDbContextAsync();

        await db.Database.MigrateAsync();
    }
}