using System;

//making of the journal
public class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();

    bool isRunning = true;

// Making of the Menu
    while (isRunning)
    {
      Console.WriteLine("Please select one of the following choices:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Save");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Display");
      Console.WriteLine("5. Exit");

      Console.Write("What number will you chose? ");

      string action = Console.ReadLine();

//first choice
      switch (action)
      {
        case "1":
          string prompt = PromptGenerator.GetRandomPrompt();

          Console.WriteLine($"Prompt= {prompt}");

          Console.Write("Enter your answer= ");

          string response = Console.ReadLine();

          journal.AddEntry(prompt, response);
          break;

// second choice

        case "2":
          Console.Write("What will the file name be? ");

          string saveFileName = Console.ReadLine();

          journal.SaveToFile(saveFileName);
          break;

// third choice

        case "3":
          Console.Write("What is the file name? ");

          string loadFileName = Console.ReadLine();

          journal.LoadFromFile(loadFileName);
          break;

// fourth choice
        case "4":
          if (journal.EntriesCount() == 0)
          {
              Console.WriteLine("The journal is empty. Add some entries first.");
          }
          else
          {
              journal.DisplayEntries();
          }
          break;

// fifth and final choice
        case "5":
          isRunning = false;

          Console.Write("Thanks for writing today, hope to see you soon!");
          break;

      }
    }
  }
}
// changed to show date and time but not sure how to just get the date. 
// changed the order of the journal because I like it better this way. 