using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Shared;

namespace InheritanceOOP.Models.Organisms.Animals.Reptiles.Snakes;

// Generic snake that doesn't belong to any species.
public class Snake : ISnake
{
    public string ScientificName => "Serpentes";
    public string CommonName => "Snake";
    public AnimalType AnimalType => AnimalType.Reptile;
    public bool IsWild => true;
    public string MakeSound => "Hisses";
    public Gender Gender { get; }
    public bool IsPoisonous { get; }

    public Snake(Gender gender, bool isPoisonous)
    {
        Gender = gender;
        IsPoisonous = isPoisonous;
    }
    
    public string SnakeEncounter()
    {
        var startMessage = $"On a nature walk, you almost stepped on a {CommonName.ToLower()}! ";
        
        var mainMessage = IsPoisonous
            ? $"It appears as if the {CommonName.ToLower()} is poisonous. You were pretty lucky to dodge this one!"
            : $"It looks like the {CommonName.ToLower()} isn't poisonous, but still, you wouldn't have had a good " +
              $"time if you had stepped on this fellow.";

        return startMessage + mainMessage;
    }
}