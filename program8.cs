using System;

// Base class
public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Derived and sealed class
public sealed class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

// Attempt to inherit from sealed class (will cause error)
public class SportsCar : Car   // ❌ ERROR: 'Car' is sealed and cannot be inherited
{
    public void TurboMode()
    {
        Console.WriteLine("Turbo mode activated!");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartEngine();
        myCar.Drive();
        myCar.StopEngine();
    }
}
