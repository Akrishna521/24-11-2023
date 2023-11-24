using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");
        int difference = num1 - num2;
        Console.WriteLine($"Difference: {difference}");
        int product = num1 * num2;
        Console.WriteLine($"Product: {product}");
        if (num2 != 0)
        {
            double quotient = (double)num1 / num2;
            Console.WriteLine($"Division: {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is undefined.");
        }
        if (num2 != 0)
        {
            int remainder = num1 % num2;
            Console.WriteLine($"Modulus: {remainder}");
        }
        else
        {
            Console.WriteLine("Modulus by zero is undefined.");
        }
    }
}