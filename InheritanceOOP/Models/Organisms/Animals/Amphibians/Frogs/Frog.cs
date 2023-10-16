using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Amphibians.Frogs;

public class Frog : IFrog
{
    public string ScientificName => "Anura";
    public string CommonName => "Frog";
    public AnimalType AnimalType => AnimalType.Amphibian;
    public bool IsWild => true;
    public Gender Gender { get; }
    public string MakeSound => "Croaks";

    public Frog(Gender gender)
    {
        Gender = gender;
    }
}