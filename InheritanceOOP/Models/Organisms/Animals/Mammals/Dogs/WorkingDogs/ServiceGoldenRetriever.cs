using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;

namespace InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.WorkingDogs;

public class ServiceGoldenRetriever : GoldenRetriever, IServiceDog
{
    public override bool IsWorkingDog => true;
    private int _yearsOfTraining;

    public int YearsOfTraining
    {
        get => _yearsOfTraining;
        set
        {
            if (value < 0)
                throw new Exception("Attempted to assign a negative value to _yearsOfTraining");
            _yearsOfTraining = value;
        }
    }

    public ServiceGoldenRetriever(string personalName, Gender gender, int yearsOfTraining) : base(personalName,
        gender)
    {
        YearsOfTraining = yearsOfTraining;
    }

    public string AssistEvent()
    {
        var startMessage = $"\nWhilst being on a walk with {PersonalName} the " + $"{CommonName}, you " +
                           $"slip on ice!";

        var mainMessage = YearsOfTraining switch
        {
            >= 1 and <= 3 => "\nYour service dog remembers training on these types of accidents and tries their " +
                             "best to help you back on your feet.",

            > 3 => $"\nBeing an experienced service dog, {PersonalName} let's out a few loud barks, as if " +
                   $"they're " +
                   $"trying to signal to any nearby humans that an accident has taken place. {PersonalName} " +
                   $"carefully bites a hold of your sleeve and drags you upwards into a sitting position. " +
                   $"{PersonalName} gives you a concerned look, as you get your head straight.",

            _ => $"\nBeing an inexperienced service dog, {PersonalName} doesn't know how to help you. Instead " +
                 $"{PersonalName} starts licking your face, believing that you're playing with them."
        };

        return startMessage + mainMessage;
    }
}