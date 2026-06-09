using System;
using System.Threading;
using System.Collections.Generic;
namespace Mindfulness;

class Program 
{
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string select = Console.ReadLine();
            
            if (select == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (select == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (select == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (select == "4")
            {
                running = false;
                Console.WriteLine("GoodBye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again!");
                Console.ReadLine();
            }
        } 
    } 
} 