using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"your name is: {last}, {name} {last}.");
    }
}