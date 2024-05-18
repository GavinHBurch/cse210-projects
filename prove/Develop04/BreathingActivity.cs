using System;
public class BreathingActivity : Activity
{  
    public BreathingActivity()
    {
        GetName("Breathing Activity");

        GetDescription("This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());

        DateTime currentTime = GetCurrentTime();

        Console.WriteLine();

        Console.Write("Breathe in..");

        ShowCountdown(2);

        Console.WriteLine();

        Console.Write("Breathe out..");

        ShowCountdown(3);

        while (currentTime <= futureTime)
        {
            Console.WriteLine();

            Console.Write("Breathe in..");

            ShowCountdown(4);

            Console.WriteLine();

            Console.Write("Breathe out..");

            ShowCountdown(6);

            Console.Write("");

            currentTime = DateTime.Now;

            Console.WriteLine("Thanks for completing the breathing exercise.");
        }
    }
}