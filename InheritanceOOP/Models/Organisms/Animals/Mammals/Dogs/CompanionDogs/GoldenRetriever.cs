using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

public class GoldenRetriever : Dog
{
    public override string CommonName => "Golden retriever";

    /*
     * To increase modularity we are using the constructor of the base class, which handles the value assignments
     * of PersonalName and Gender, which this class inherits.
     */
    public GoldenRetriever(string personalName, Gender gender) : base(personalName, gender)
    {
    }
}