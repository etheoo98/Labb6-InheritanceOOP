using InheritanceOOP.Interfaces.Organisms;

namespace InheritanceOOP.Models.Organisms.Plants.Flowers.Marigolds;

// Marked as an abstract class since Marigold is a collective word for a family of flowers.
public abstract class Marigold : IOrganism
{
    public abstract string ScientificName { get; }
    public abstract string CommonName { get; }
}