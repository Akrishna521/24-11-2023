using System;

public class Program
{
    public static void Main()
    {
        int age;
        Console.WriteLine("Enter your age: ");
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        Console.WriteLine("Your age is: {0}", age);
        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior.");
        }
    }
}