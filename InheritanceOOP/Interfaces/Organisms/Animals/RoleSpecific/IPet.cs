namespace InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;

// Inheritors of this interface should be considered as companion dogs: I.e. pets.
public interface IPet
{
    // Implementations should contain the pet's response to being petted.
    public string Pet();
}