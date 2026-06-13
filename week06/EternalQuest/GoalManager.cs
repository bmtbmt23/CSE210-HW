using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
             if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.");
        }
        public void ListGoalNames()
        {
            int number = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{number}, {goal.GetName()}");
                number++;
            }
        }
        public void ListGoalDetails()
        {
            Console.WriteLine("\nThe goals are: ");
            
            if (_goals.Count == 0)
            {
                Console.WriteLine("Not goals yet.");
            }
            else 
            {
                for(int i = 0; i<_goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{_goals[i]}");
                }
            }

        }

        public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine(" 1.Simple Goal");
        Console.WriteLine(" 2.Eternal Goal");
        Console.WriteLine(" 3.Checklist Goal");
        Console.WriteLine("Which type goal would you like to create?");
        string type = Console.ReadLine();

        Console.WriteLine("Which type of goal would you like to create? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of point associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (type == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int goal = int.Parse("Console.ReadLine()");
            Console.WriteLine("What is the bonus for accomplishing it that many time? ");
            int bonus = int.Parse(Console.ReadLine());

            Console.ReadLine();

            _goals.Add(new ChecklistGoal(name, description, points, goal, bonus )); 
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();

        int gotDone = int.Parse(Console.ReadLine()) -1;

        if (gotDone >= 0 && gotDone <_goals.Count)
        {
            Goal goal = _goals[gotDone];
            goal.RecordEvent();
        }
    }
    
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for this goal? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Your goals are saved successfully");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Loading...");
    }
}
    
