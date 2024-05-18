using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        GetName("Listing Activity");

        GetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();

        int index = random.Next(0, _prompts.Count);

        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();

        Console.WriteLine();

        Console.WriteLine("List as many responses as you can in the given time.:");

        Console.WriteLine($"- {prompt} -");

        Console.Write("Starting in: ");

        ShowCountdown(5);

        Console.WriteLine();
                
        DateTime futureTime = GetFutureTime(GetDuration());

        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write("=");

            Console.ReadLine();

            currentTime = DateTime.Now;
        }

        Console.WriteLine("Thanks for completing the listing exercise.");
    }
}