using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

public class Pomeranian : Dog, IPet
{
    public override string CommonName => "Pomeranian";
    public override bool IsWorkingDog => false;

    public Pomeranian(string personalName, Gender gender) : base(personalName, gender)
    {
    }

    public string Pet() => $"You pet {PersonalName}, whose tail starts wagging.";
}