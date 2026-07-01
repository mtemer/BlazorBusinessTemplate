using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Data;

/// <summary>
/// Base application database context.
/// Automatically manages audit fields on entities.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Creates a new application database context.
    /// </summary>
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
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
        var now = DateTime.Now;

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