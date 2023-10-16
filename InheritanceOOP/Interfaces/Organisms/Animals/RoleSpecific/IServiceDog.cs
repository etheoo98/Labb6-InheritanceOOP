namespace InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;

// Inheritors of this interface should be considered as service dogs.
public interface IServiceDog
{
    /*
     * Specify the amount of years the service dog has been in training for.
     * This can be used as a condition in AssistEvent();
     */
    public int YearsOfTraining { get; }
    // Implementations should contain a scenario where the service dog assists someone.
    public string AssistEvent();
}