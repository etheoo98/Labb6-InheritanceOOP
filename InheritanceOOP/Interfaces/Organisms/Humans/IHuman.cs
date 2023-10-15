namespace InheritanceOOP.Interfaces.Organisms.Humans;

// Inheritors of this interface should be considered as humans.
public interface IHuman : IOrganism
{
    public DateTime DateOfBirth { get; }
}