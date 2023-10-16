using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Amphibians.Frogs;

// Generic frog that doesn't belong to any species.
public class Frog : IFrog
{
    public string ScientificName => "Anura";
    public string CommonName => "Frog";
    public AnimalType AnimalType => AnimalType.Amphibian;
    public bool IsWild => true;
    public string MakeSound => "Croaks";
    public Gender Gender { get; }

    public int MaxLeapDistance
    {
        get => _maxLeapDistance;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _maxLeapDistance");
            if(value > 10)
                throw new Exception("Attempted to assign value greater than 10 to _maxLeapDistance");
            _maxLeapDistance = value;
        }
    }

    public Frog(Gender gender, int maxLeapDistance = 10)
    {
        Gender = gender;
        MaxLeapDistance = maxLeapDistance;
    }

    public string Leap()
    {
        var random = new Random();
        var leapDistance = random.Next(1, MaxLeapDistance);
        
        var startMessage = $"This {CommonName} can leap upwards to {MaxLeapDistance} meters. " +
                           $"Look! It's about to leap! "; // This is horrible.

        var mainMessage = leapDistance switch
        {
            > 0 and < 4 => $"The {CommonName.ToLower()} didn't leap that far.",
            < 7 => $"The {CommonName.ToLower()} made quite the leap! That must have been close to " +
                   $"{leapDistance} meters!",
            _ => $"Wow! What a leap! That's a whopping {leapDistance} leap distance right there!"
        };

        return startMessage + mainMessage;
    }

    private int _maxLeapDistance;
}