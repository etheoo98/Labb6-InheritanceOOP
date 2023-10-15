using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Reptiles.Snakes;

public class Snake : IAnimal, IAudibleEntity
{
    public string ScientificName => "Serpentes";
    public string CommonName => "Snake";
    public Gender Gender { get; }
    public AnimalType AnimalType => AnimalType.Reptile;
    public bool IsWild => true;
    public string MakeSound => "Hisses";

    public Snake(Gender gender)
    {
        Gender = gender;
    }
}