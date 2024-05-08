using System;

// prompt generator
public class PromptGenerator
{
    // questions in my get random prompts

    public static string GetRandomPrompt()
  {
    List<string> prompts = new List<string>
        {
            "Who made you laugh today?",
            "How productive were you today?",
            "Did you learn something new today?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
  
        };

        //Returning Random Prompts
   Random random = new Random();

    int index = random.Next(prompts.Count);

    return prompts[index];
  }
}