using System;
class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while(playAgain)
        {
            int guesses = 0;
            int guess = -1;
            string response;
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
        
            while(guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                guesses ++;
                
                if (guess > magicNumber)
                {
                    Console.WriteLine($"{guess} too high!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine($"{guess} too low!");
                }
                
            }
            
            Console.WriteLine($"You guessed it in {guesses} tries!");
            
            Console.WriteLine("Would you like to play again (Y/N): ");
            response = Console.ReadLine().ToUpper();
            
            if(response != "Y")
            {
                playAgain = false;
            }
        }
        
        Console.WriteLine("Thanks for playing!");
    }
    
}