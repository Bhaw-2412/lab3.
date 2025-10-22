using System;

// Abstract base class
public abstract class Shape
{
    public abstract double CalculateArea(); // Abstract method (no body)
}

// Derived class: Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class: Rectangle
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

// Main program
class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
        Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
    }
}
