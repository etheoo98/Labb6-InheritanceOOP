namespace InheritanceOOP.Interfaces.Organisms.Shared;

// Inheritors of this interface have a personal name that is preferred to their common and scientific name.
public interface INamedEntity
{
    // Implementations should contain the entity's personal name.
    public string? PersonalName { get; }
}