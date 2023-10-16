using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Amphibians.Frogs;

// Generic frog that doesn't belong to any species.
public class Frog : IFrog
{
    public string ScientificName => "Anura";
    public string CommonName => "Frog";
    public AnimalType AnimalType => AnimalType.Amphibian;
    public bool IsWild => true;
    public string MakeSound => "Croaks";
    public Gender Gender { get; }

    public Frog(Gender gender)
    {
        Gender = gender;
    }
}