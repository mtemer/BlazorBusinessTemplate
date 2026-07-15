using BlazorBusinessTemplate.Core;
using BlazorBusinessTemplate.Samples.Todo.Data;
using BlazorBusinessTemplate.Samples.Todo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorBusinessTemplate.Samples.Todo.Services;

/// <summary>
/// Provides Todo operations.
/// </summary>
public sealed class TodoService
{
    private readonly IDbContextFactory<TodoDbContext> _factory;

    /// <summary>
    /// Creates a new Todo service.
    /// </summary>
    public TodoService(
        IDbContextFactory<TodoDbContext> factory)
    {
        _factory = factory;
    }

    /// <summary>
    /// Gets all Todo items.
    /// </summary>
    public async Task<Result> AddAsync(
        TodoCreateModel model)
    {
        Guard.NotNull(model);

        Guard.NotNullOrWhiteSpace(model.Title);

        await using var db =
            await _factory.CreateDbContextAsync();

        db.TodoItems.Add(new TodoItem
        {
            Title = model.Title
        });

        await db.SaveChangesAsync();

        return Result.Ok();
    }
}