using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
       
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());


        int guess = 12;

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }


        

    }

}