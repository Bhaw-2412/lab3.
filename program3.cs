using System;

public static class Logger
{
    // Static method for logging messages
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger.LogMessage("Application Started.");

        // Example usage
        int[] numbers = { 5, 10, 15, 20 };
        double avg = MathHelper.CalculateAverage(numbers);

        Logger.LogMessage($"Calculated Average: {avg}");
        Logger.LogMessage("Application Ended.");
    }
}
