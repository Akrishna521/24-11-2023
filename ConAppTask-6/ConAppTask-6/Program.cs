using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
    }
}