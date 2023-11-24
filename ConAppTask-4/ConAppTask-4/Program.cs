using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}