namespace InheritanceOOP.Interfaces.Organisms.Shared;

// Inheritors of this interface should be considered as audible: I.e. can make sounds.
public interface IAudibleEntity
{
    // Implementations should contain a sound that the entity makes.
    public string MakeSound { get; }
}