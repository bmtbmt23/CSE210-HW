using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = Convert.ToInt32(Console.ReadLine());
        
        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
             
        string sign = "";
        int lastDigit = grade %10;
        

        if (lastDigit <3 )
        {
            sign ="-";
        }
        else if (lastDigit >=7)
        {
            sign ="+";
        }
        
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        
        if (letter == "F")
        {
            
        }
    
        Console.WriteLine($"Your grade is: {letter}{sign}.");
        
        if (grade >70)
        {
            Console.WriteLine("Congradulation! You Passed!");
        }
        else
        {
            Console.WriteLine("Sorry, You can try again!");
        }
        
        Console.ReadKey();
    }
}