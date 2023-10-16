using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Interfaces.Organisms.Animals;

// Inheritors of this interface should be considered as snakes.
public interface ISnake : IAnimal, IAudibleEntity
{
}