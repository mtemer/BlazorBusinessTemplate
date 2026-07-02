using BlazorBusinessTemplate.Core;
using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Extensions;

/// <summary>
/// Provides extension methods for DbContext.
/// </summary>
public static class DbContextExtensions
{
    /// <summary>
    /// Saves all pending changes and returns a Result.
    /// </summary>
    public static async Task<Result> SaveResultAsync(
        this DbContext context,
        CancellationToken cancellationToken = default)
    {
        Guard.NotNull(context);

        await context.SaveChangesAsync(cancellationToken);

        return Result.Ok();
    }
}