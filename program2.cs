using System;

public static class MathHelper
{
    
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Array is empty!");
            return 0;
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 10, 20, 30, 40, 50 };
        double avg = MathHelper.CalculateAverage(nums);

        Console.WriteLine("Average = " + avg);
    }
}
