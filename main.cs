using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer;

        Console.WriteLine("Please enter an integer");
        Console.WriteLine("");

        Console.Write("integer: ");
        integer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (integer >= 0)
        {
    Console.WriteLine("Your number is positive");
        }
        else
        {
    Console.WriteLine("Your number is negative");
        }

        Console.WriteLine("\nDone.");
    }
}