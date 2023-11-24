using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number) && number >= 0)
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number}: {factorial}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }
    }
    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}