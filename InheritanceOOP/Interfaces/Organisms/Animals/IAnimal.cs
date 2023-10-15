using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Interfaces.Organisms.Animals;

// Enum to restrict allowed values for the property AnimalType.
public enum AnimalType
{
    Mammal,
    Reptile,
    Amphibian
}

// Inheritors of this interface should be considered as animals.
public interface IAnimal : IOrganism, IGenderedEntity
{
    public AnimalType AnimalType { get; }
    public bool IsWild { get; }
}