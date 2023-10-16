using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Interfaces.Organisms.Animals;

// Inheritors of this interface should be considered as frogs.
public interface IFrog : IAnimal, IAudibleEntity
{
    // MaxLeapDistance is defined in meters.
    public int MaxLeapDistance { get; }
    public string Leap();
}