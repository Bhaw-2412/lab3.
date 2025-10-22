using System;

// Abstract base class
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Abstract method to be implemented by derived classes
    public abstract void Speak();

    // Concrete method (common to all animals)
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived class: Dog
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof! Woof!");
    }
}

// Derived class: Cat
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

// Main program
class Program
{
    static void Main()
    {
        Dog dog = new Dog { Name = "Bruno", Age = 3 };
        Cat cat = new Cat { Name = "Kitty", Age = 2 };

        dog.DisplayInfo();
        dog.Speak();

        cat.DisplayInfo();
        cat.Speak();
    }
}
