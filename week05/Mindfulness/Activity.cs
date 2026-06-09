using System;
namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration; 
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity(); 
        DisplayEndingMessage();
    }
    
    private void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}. \n");
        Console.WriteLine($"{_description} \n");
        Console.Write("How many seconds do you want to practice this for? ");
        
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Enter a valid number: ");
        }
        
        Console.Clear();
        Console.WriteLine("Loading...");
        Loading(3);
        Console.WriteLine();
    }
       private void DisplayEndingMessage()
    {
    
        Loading(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Loading(3);
        Console.WriteLine("\nWell done!!");
    }
    
    protected virtual void PerformActivity()
    {
    }
    
    protected void Loading(int seconds)
    {
        List<string> LoadingStrings = new List<string> ();
        LoadingStrings.Add("|");
        LoadingStrings.Add("/");
        LoadingStrings.Add("-");
        LoadingStrings.Add("\\");
        LoadingStrings.Add("|");
        LoadingStrings.Add("/");
        LoadingStrings.Add("-");
        LoadingStrings.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
       
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = LoadingStrings[i];
            Console.Write(s);
            Thread.Sleep(150);
            Console.Write("\b \b");
           
            i++;
           
            if (i >= LoadingStrings.Count)
            {
                i = 0;
            }
        }
    }
}
