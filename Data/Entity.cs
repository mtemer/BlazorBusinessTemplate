namespace BlazorBusinessTemplate.Data;

/// <summary>
/// Base class for application entities.
/// </summary>
public abstract class Entity : IEntity
{
    /// <inheritdoc />
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified.
    /// </summary>
    public DateTime ModifiedOn { get; set; }
}