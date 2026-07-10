using BlazorBusinessTemplate.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Samples.Todo.Data;

/// <summary>
/// Database context for the Todo sample application.
/// </summary>
public sealed class TodoDbContext : AppDbContext
{
    /// <summary>
    /// Creates a new Todo database context.
    /// </summary>
    public TodoDbContext(
        DbContextOptions<TodoDbContext> options,
        TimeProvider timeProvider)
        : base(options, timeProvider)
    {
    }

    /// <summary>
    /// Gets the Todo items.
    /// </summary>
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}