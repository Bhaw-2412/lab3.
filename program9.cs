using System;

// Base class
public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }
}

// Sealed derived class
public sealed class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; } = 0.05; // 5%

    public void CalculateInterest()
    {
        double interest = Balance * InterestRate;
        Console.WriteLine($"Interest Earned: {interest}");
        Balance += interest;
        Console.WriteLine($"Balance after interest: {Balance}");
    }
}

// Attempt to inherit (will cause error)
public class PremiumSavings : SavingsAccount   // ❌ ERROR: cannot derive from sealed type
{
    public void Bonus()
    {
        Console.WriteLine("Bonus credited!");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount acc = new SavingsAccount
        {
            AccountNumber = "123456789",
            Balance = 10000
        };

        acc.Deposit(2000);
        acc.CalculateInterest();
        acc.Withdraw(5000);
    }
}
