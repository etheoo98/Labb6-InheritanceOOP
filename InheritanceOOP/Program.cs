/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://www.github.com/etheoo98/Labb5-InheritanceOOP
 * Date: October 15, 2023
 */

using InheritanceOOP.Interfaces.Organisms;
using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;
using InheritanceOOP.Models.Organisms;
using InheritanceOOP.Models.Organisms.Animals.Amphibians.Frogs;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.CompanionDogs;
using InheritanceOOP.Models.Organisms.Animals.Mammals.Dogs.WorkingDogs;
using InheritanceOOP.Models.Organisms.Animals.Reptiles.Snakes;
using InheritanceOOP.Models.Organisms.Humans;
using InheritanceOOP.Models.Organisms.Plants.Flowers.Marigolds;

namespace InheritanceOOP;

internal static class Program
{
    public static void Main()
    {
        // Create a list of IOrganisms
        var organisms = new List<IOrganism>
        {
            new Frog(Gender.Male),
            new Snake(Gender.Female),
            new Dog("Tyson", Gender.Male),
            new HomoSapiens("Billy", new DateTime(1973, 10, 12), Gender.Male),
            new GuardGermanShepherd("Roxy", Gender.Female),
            new ServiceGoldenRetriever("Bogoslav", Gender.Male, 5),
            new Pomeranian("Timo", Gender.Male),
            new FrenchMarigold()
        };
        
        // Iterate over each element in the list.
        foreach (var organism in organisms)
        {
            // Check if current element matches any case.
            switch (organism)
            {
                case IGuardDog guardDog:
                    Console.WriteLine(guardDog.GuardEvent());
                    break;
                case IServiceDog serviceDog:
                    Console.WriteLine(serviceDog.AssistEvent());
                    break;
                case IPet pet:
                    Console.WriteLine($"\n{pet.Pet()}");
                    break;
                case Human human:
                    Console.WriteLine($"\n{human.PersonalName} the {human.CommonName} says: \"{human.MakeSound}\"");
                    break;
                case IAnimal animal and IAudibleEntity audibleEntity:
                    Console.WriteLine($"The {animal.CommonName.ToLower()} {audibleEntity.MakeSound.ToLower()}.");
                    break;
                default:
                    Console.WriteLine($"\nThe scientific name of {organism.CommonName} is {organism.ScientificName}.");
                    break;
            }
        }
    }
}