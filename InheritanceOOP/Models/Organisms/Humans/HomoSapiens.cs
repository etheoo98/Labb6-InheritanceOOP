using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Humans;

public class HomoSapiens : Human
{
    public override string ScientificName => "Homo Sapiens";
    public override string CommonName => "Human";
    public override string MakeSound => "Why yes, these animals are quite extraordinary indeed!";
    public override DateTime DateOfBirth { get; }
    public override Gender Gender { get; }

    /*
     * To increase modularity we are also using the constructor of the base class, which handles the value assignment
     * of PersonalName, which this class inherits.
     */
    public HomoSapiens(string personalName, DateTime dateOfBirth, Gender gender) : base(personalName)
    {
        PersonalName = personalName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
    }
}