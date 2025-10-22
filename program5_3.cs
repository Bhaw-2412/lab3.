using System;

class Program5_3
{
    static void Main()
    {
        Employee emp = new Employee
        {
            EmployeeId = 101,
            Name = "Aarav Sharma",
            BasicSalary = 40000,
            Allowances = 8000,
            Deductions = 3000
        };

        emp.DisplaySalaryDetails();
    }
}
