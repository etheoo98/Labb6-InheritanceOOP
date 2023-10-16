using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs;

public class Dog : IDog
{
    private string? _personalName;

    public string? PersonalName
    {
        get => _personalName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Attempted to assign Null or Empty to _personalName");
            _personalName = value;
        }
    }
    public string ScientificName => "Canis lupus familiaris";
    public virtual string CommonName => "Dog";
    public AnimalType AnimalType => AnimalType.Mammal;
    public bool IsWild => false;
    public Gender Gender { get; }
    public string MakeSound => "Barks";
    public virtual bool IsWorkingDog => false;

    public Dog(string personalName, Gender gender)
    {
        PersonalName = personalName;
        Gender = gender;
    }
}