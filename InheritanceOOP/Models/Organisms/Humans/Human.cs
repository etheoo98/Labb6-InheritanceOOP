using InheritanceOOP.Interfaces.Organisms.Humans;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Humans;

// Marked as abstract since inheritors are intended to be specific human species.
public abstract class Human : IHuman
{
    public abstract string ScientificName { get; }
    public abstract string CommonName { get; }
    public abstract DateTime DateOfBirth { get; }
    public abstract string MakeSound { get; }
    public abstract Gender Gender { get; }
    /*
     * In order to prevent null or empty values from being assigned to the _personalName field, we throw an exception if
     * this is the case. Preferably there should only be one implementation of this error handling, since this is the
     * same implementation seen in the Dog class.
     */
    public string PersonalName
    {
        get => _personalName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Attempted to assign Null or Empty to _personalName");
            _personalName = value;
        }
    }

    protected Human(string personalName)
    {
        PersonalName = personalName;
    }
    
    private string _personalName = null!;
}