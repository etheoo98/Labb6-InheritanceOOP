using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Interfaces.Organisms.Humans;

// Inheritors of this interface are considered as belonging to a human species.
public interface IHuman : IOrganism, INamedEntity, IAudibleEntity, IGenderedEntity
{
    public DateTime DateOfBirth { get; }
}