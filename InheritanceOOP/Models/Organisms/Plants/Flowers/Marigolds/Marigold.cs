using InheritanceOOP.Interfaces.Organisms;

namespace InheritanceOOP.Models.Organisms.Plants.Flowers.Marigolds;

public abstract class Marigold : IOrganism
{
    public abstract string ScientificName { get; }
    public abstract string CommonName { get; }
}