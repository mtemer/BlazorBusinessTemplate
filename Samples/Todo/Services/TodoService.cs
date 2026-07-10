using Microsoft.EntityFrameworkCore;
namespace BlazorBusinessTemplate.Samples.Todo.Data;

public sealed class TodoService
{
    private readonly IDbContextFactory<TodoDbContext> _factory;

    public TodoService(
        IDbContextFactory<TodoDbContext> factory)
    {
        _factory = factory;
    }
}