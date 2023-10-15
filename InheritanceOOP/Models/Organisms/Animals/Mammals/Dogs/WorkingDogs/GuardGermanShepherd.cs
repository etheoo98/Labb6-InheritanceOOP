using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.WorkingDogs;

public class GuardGermanShepherd : GermanShepherd, IGuardDog
{
    public override bool IsWorkingDog => true;

    public GuardGermanShepherd(string personalName, Gender gender) : base(personalName, gender)
    {
    }

    public string GuardEvent()
    {
        var random = new Random();
        var intruderSpotted = random.Next(0, 2) % 2 == 0;

        var startMessage = $"\n{PersonalName} the {CommonName} starts patrolling the area. ";
        string mainMessage;

        if (intruderSpotted)
        {
            mainMessage = $"\nSuddenly, {PersonalName} spots an intruder! {PersonalName} immediately starts " +
                          $"barking loudly, which scares away the intruder. ";
        }
        else
        {
            mainMessage = "\nNothing seems to be out of the ordinary. ";
        }

        var endMessage = $"\nAfter some time, {PersonalName} returns to you.";

        return startMessage + mainMessage + endMessage;
    }
}