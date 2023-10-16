using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

public class Pomeranian : Dog
{
    public override string CommonName => "Pomeranian";

    /*
     * To increase modularity we are using the constructor of the base class, which handles the value assignments
     * of PersonalName and Gender, which this class inherits.
     */
    public Pomeranian(string personalName, Gender gender) : base(personalName, gender)
    {
    }
}