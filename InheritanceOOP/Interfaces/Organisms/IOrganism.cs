namespace InheritanceOOP.Interfaces.Organisms;

// Inheritors of this interface should be considered as organisms.
public interface IOrganism
{
    public string ScientificName { get; }
    public string CommonName { get; }
}