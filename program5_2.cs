using System;

public partial class Employee
{
    public double CalculateNetSalary()
    {
        return BasicSalary + Allowances - Deductions;
    }

    public void DisplaySalaryDetails()
    {
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine($"Basic Salary: {BasicSalary}");
        Console.WriteLine($"Allowances: {Allowances}");
        Console.WriteLine($"Deductions: {Deductions}");
        Console.WriteLine($"Net Salary: {CalculateNetSalary()}");
    }
}
