namespace InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;

public enum PetFood
{
    Meat,
    Fish,
}

// Inheritors of this interface should be considered as pets.
public interface IPet
{
    /*
     * Implementations should contain the pet's response to being petted, fed and played with.
     * The IsHungry flag may be used as a condition in these methods.
     */
    public bool IsHungry { get; set; }
    public PetFood FavoriteFood { get; }
    public string Pet();
    public string Feed(PetFood petFood);
    public string Play();
}