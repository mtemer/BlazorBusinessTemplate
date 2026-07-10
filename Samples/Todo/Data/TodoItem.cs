using BlazorBusinessTemplate.Data;

namespace BlazorBusinessTemplate.Samples.Todo.Data;

/// <summary>
/// Represents a task in the Todo sample application.
/// </summary>
public sealed class TodoItem : Entity
{
    /// <summary>
    /// Gets or sets the task title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets whether the task is completed.
    /// </summary>
    public bool IsCompleted { get; set; }
}