namespace InheritanceOOP.Interfaces.Organisms.Shared;

// Enum to restrict allowed values for the property Gender.
public enum Gender
{
    Male,
    Female
}

// Inheritors of this interface should be considered as being gendered.
public interface IGenderedEntity
{
    public Gender Gender { get; }
}