namespace BlazorBusinessTemplate.Samples.Todo.Models;

/// <summary>
/// Represents data required to create a Todo item.
/// </summary>
public sealed class TodoCreateModel
{
    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    public string Title { get; set; } = string.Empty;
}