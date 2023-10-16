using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs;

// Generic dog that doesn't belong to any species.
public class Dog : IDog
{
    public string ScientificName => "Canis lupus familiaris";
    public virtual string CommonName => "Dog";
    public AnimalType AnimalType => AnimalType.Mammal;
    public bool IsWild => false;
    public string MakeSound => "Barks";
    public virtual bool IsWorkingDog => false;
    public bool IsHungry { get; set; }
    public PetFood FavoriteFood => PetFood.Meat;

    /*
     * In order to prevent null or empty values from being assigned to the _personalName field, we throw an exception if
     * this is the case.
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
    public Gender Gender { get; }

    public Dog(string personalName, Gender gender)
    {
        PersonalName = personalName;
        Gender = gender;
    }
    
    public string Pet() => $"You pet {PersonalName} the {CommonName.ToLower()}, whose tail starts wagging.";
    public string Feed(PetFood petFood)
    {
        var startMessage = $"{PersonalName} looks up to you, because they can tell you brought food for them. ";
        string mainMessage;
        
        if (IsHungry && petFood == FavoriteFood)
        {
            mainMessage = $"{petFood} is obviously a dog's favorite food! And {PersonalName} just happens to be " +
                          $"starving! {PersonalName} eats it all up in one go, and is no longer hungry.";
            IsHungry = false;
        }
        else if (IsHungry && petFood != FavoriteFood)
        {
            mainMessage = $"How unfortunate. {PersonalName} is hungry, but you brought food that no sane dog would " +
                          $"dare to touch. {PersonalName} looks at you in disappointment and is obviously still hungry.";
        }
        else
        {
            mainMessage = $"Unlucky for you, {PersonalName} isn't hungry at the moment and is quickly distracted by " +
                          $"something else.";
        }

        return startMessage + mainMessage;
    }
    public string Play()
    {
        var startMessage = $"You approach {PersonalName} and attempt to play with them. ";
        string mainMessage;
        
        if (IsHungry)
        {
            mainMessage = $"However, {PersonalName} is in no mood to play, and was actually expecting you to bring " +
                          $"them food. It appears as if {PersonalName} is hungry.";
        }
        else
        {
            mainMessage = $"{PersonalName} is happy to join in on the fun and starts playfully running around. Once " +
                          $"you're finished, the thought crosses your mind that playing with {PersonalName} might " +
                          $"have made them hungry.";
            IsHungry = true;
        }

        return startMessage + mainMessage;
    }

    private string _personalName = null!;
}