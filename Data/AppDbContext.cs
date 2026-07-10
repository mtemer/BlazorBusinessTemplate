using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Data;

/// <summary>
/// Base application database context.
/// Automatically manages audit fields on entities.
/// </summary>
public abstract class AppDbContext : DbContext
{
    private readonly TimeProvider _timeProvider;

    /// <summary>
    /// Creates a new application database context.
    /// </summary>
    protected AppDbContext(
        DbContextOptions options,
        TimeProvider timeProvider)
        : base(options)
    {
        _timeProvider = timeProvider;
    }

    /// <inheritdoc />
    public override int SaveChanges()
    {
        ApplyAuditFields();

        return base.SaveChanges();
    }

    /// <inheritdoc />
    public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default)
    {
        ApplyAuditFields();

        return base.SaveChangesAsync(cancellationToken);
    }

    private void ApplyAuditFields()
    {
        var now =
            _timeProvider
                .GetLocalNow()
                .DateTime;

        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedOn = now;
                entry.Entity.ModifiedOn = now;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.ModifiedOn = now;
            }
        }
    }
}