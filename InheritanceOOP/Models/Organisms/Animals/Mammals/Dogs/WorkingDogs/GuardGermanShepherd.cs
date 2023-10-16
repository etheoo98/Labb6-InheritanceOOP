using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.WorkingDogs;

public class GuardGermanShepherd : GermanShepherd, IGuardDog
{
    public override bool IsWorkingDog => true;

    /*
     * To increase modularity we are using the constructor of the base class, which handles the value assignments
     * of PersonalName and Gender, which this class inherits.
     */
    public GuardGermanShepherd(string personalName, Gender gender) : base(personalName, gender)
    {
    }

    public string GuardEvent()
    {
        var random = new Random();
        var intruderSpotted = random.Next(0, 2) % 2 == 0;

        var startMessage = $"Your guard dog, {PersonalName} the {CommonName} starts patrolling the area. ";
        string mainMessage;

        if (intruderSpotted)
        {
            mainMessage = $"Suddenly, {PersonalName} spots an intruder! {PersonalName} immediately starts " +
                          $"barking loudly, which scares away the intruder. ";
        }
        else
        {
            mainMessage = "Nothing seems to be out of the ordinary. ";
        }

        var endMessage = $"After some time, {PersonalName} returns to you.";

        return startMessage + mainMessage + endMessage;
    }
}