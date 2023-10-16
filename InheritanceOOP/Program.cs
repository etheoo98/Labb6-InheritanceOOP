/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://www.github.com/etheoo98/Labb5-InheritanceOOP
 * Date: October 15, 2023
 */

using InheritanceOOP.Interfaces.Organisms;
using InheritanceOOP.Interfaces.Organisms.Animals;
using InheritanceOOP.Interfaces.Organisms.Animals.RoleSpecific;
using InheritanceOOP.Interfaces.Organisms.Shared;
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
        var frog = new Frog(Gender.Male);
        var snake = new Snake(Gender.Female, true);
        var dog = new Dog("Tyson", Gender.Male);
        var homoSapiens = new HomoSapiens("Billy", new DateTime(1973, 10, 12), Gender.Male);
        var guardGermanShepherd = new GuardGermanShepherd("Roxy", Gender.Female);
        var serviceGoldenRetriever = new ServiceGoldenRetriever("Bogoslav", Gender.Male, 5);
        var pomeranian = new Pomeranian("Timo", Gender.Male);
        var frenchMarigold = new FrenchMarigold();

        Console.WriteLine($"The {frog.CommonName.ToLower()} {frog.MakeSound.ToLower()}.");
        Console.WriteLine($"The {snake.CommonName.ToLower()} {snake.MakeSound.ToLower()}.");
        Console.WriteLine($"The {dog.CommonName.ToLower()} {dog.MakeSound.ToLower()}.");
        Console.WriteLine($"\n{homoSapiens.PersonalName} the {homoSapiens.CommonName} says: \"{homoSapiens.MakeSound}\"");
        Console.WriteLine($"\n{guardGermanShepherd.GuardEvent()}");
        Console.WriteLine($"\n{serviceGoldenRetriever.AssistEvent()}");
        Console.WriteLine($"\n{pomeranian.Pet()}");
        Console.WriteLine($"\n{pomeranian.Play()}");
        Console.WriteLine($"\n{pomeranian.Feed(PetFood.Meat)}");
        Console.WriteLine($"\n{snake.SnakeEncounter()}");
        Console.WriteLine($"\n{frog.Leap()}");
        
        Console.WriteLine($"\nThe scientific name of {frenchMarigold.CommonName} is {frenchMarigold.ScientificName}.");
    }
}