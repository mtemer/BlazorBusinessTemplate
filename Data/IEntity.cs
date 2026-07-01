namespace BlazorBusinessTemplate.Data;

/// <summary>
/// Represents an entity with a unique integer identifier.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Gets or sets the entity identifier.
    /// </summary>
    int Id { get; set; }
}