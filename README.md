# Labb6-InheritanceOOP
C# console application made for a beginners programming course.

## Assignment Description
In this assignment, you will practice using inheritance in object-oriented programming. The assignment is largely about designing a structure for inheritance but also about implementing it in code.

### What you need to do
Imagine that you are creating a foundation for a program that manages animals in a zoo.
- There should be a base class called Animal.
  - The class should have at least five properties that all animals share.
  - The class should also have at least three methods that all animals share.
- You need to create at least three different animals that inherit from the Animal class.
  - These animals should implement at least one new property each and at least one new method each.
  - These animals should also have default values for the properties, both those set in the class and those set in the base class.
  - All animals must have a method called MakeSound() that prints the animal's sound to the console.
  - There should be a constructor that can be used to create new animals.
- One of the animals you created above should be divided into two new classes that inherit from that animal.
  - For example, if you have a dog, you can create Bulldog and Chihuahua. The result is inheritance at two levels.
  - These animal variants should also implement some unique property and some unique method, or at least an override that makes them unique.
- In your Main method, you should initialize several different animals and ensure that they make their sounds so that it is visible in the console that the animals have made sounds.

### Extra challenge
If you want a bit more of a challenge, you can try to implement the following:
- Include humans as animals.
- Expand the structure to differentiate between mammals and reptiles.
- Expand the program so that there is also a distinction between wild and domesticated animals.
- Expand the program so that the structure also includes plants.
