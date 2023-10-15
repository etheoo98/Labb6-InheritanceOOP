using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

public class GermanShepherd : Dog
{
    public override string CommonName => "German shepherd";
    public override bool IsWorkingDog => false;

    public GermanShepherd(string personalName, Gender gender) : base(personalName, gender)
    {
    }
}