using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Reptiles.Snakes;

// Generic snake that doesn't belong to any species.
public class Snake : ISnake
{
    public string ScientificName => "Serpentes";
    public string CommonName => "Snake";
    public AnimalType AnimalType => AnimalType.Reptile;
    public bool IsWild => true;
    public string MakeSound => "Hisses";
    public Gender Gender { get; }

    public Snake(Gender gender)
    {
        Gender = gender;
    }
}