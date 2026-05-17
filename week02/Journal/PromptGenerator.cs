using System;
using System.Collections.Generic;
// PromptGenerator Class

public class PromptGenerator
{
  public List<string> _prompts = new List<string>()
     {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What lesson did I learn today?",
        "How did I feel the Spirit today?",
        "How did I show love to others today?",
    };

  public string GetRandomPrompt()
  {
      Random randomGenerator = new Random();
     
      int index = randomGenerator.Next(_prompts.Count);
      return _prompts[index];
  }
}
