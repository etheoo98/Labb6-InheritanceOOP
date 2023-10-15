using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

public class GoldenRetriever : Dog
{
    public override string CommonName => "Golden retriever";
    public override bool IsWorkingDog => false;

    public GoldenRetriever(string personalName, Gender gender) : base(personalName, gender)
    {
    }
}