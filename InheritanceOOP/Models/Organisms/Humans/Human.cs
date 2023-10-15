using InheritanceOOP.Interfaces.Organisms.Humans;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Humans;

public abstract class Human : IHuman, INamedEntity, IAudibleEntity, IGenderedEntity
{
    private string? _personalName;

    public string? PersonalName
    {
        get => _personalName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Attempted to assign Null or Empty to _personalName");
            _personalName = value;
        }
    }

    public abstract string ScientificName { get; }
    public abstract string CommonName { get; }
    public abstract DateTime DateOfBirth { get; }
    public abstract string MakeSound { get; }
    public abstract Gender Gender { get; }

    protected Human(string personalName)
    {
        PersonalName = personalName;
    }
}