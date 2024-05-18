using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = "";

        _description = "";

        _duration = 15;
    }
    public void GetName(string name)
    {
        _name = name;
    }
    public void GetDescription(string description)
    {
        _description = description;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}.");

        Console.WriteLine();

        Console.WriteLine(_description);
    }
    public void Duration()
    {
        Console.WriteLine();

        Console.Write("How long would you like for your session(in seconds)? ");

        string durationString = Console.ReadLine();
        
    }
    public void GetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void Run()
    {
        Console.Clear();

        ShowDetails();

        Duration();

        GetReady();
    }

    public void StopActivity()
    {
        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine($"You have done a great job!");

        ShowSpinner(5);

        Console.WriteLine();

    }

    public void ShowSpinner(int totalSeconds)
    {
        int spinnerPosition = 50;

        int spinWait = 1000;

        spinnerPosition = Console.CursorLeft;

        DateTime futureTime = GetFutureTime(5);

        while(DateTime.Now < futureTime)
        {
            char[] spinChars = new char[]{'-','/','-','/'};

            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;

                Console.Write(spinChar);

                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;

    }

    public void ShowCountdown(int totalSeconds)
    {
        int timerPosition = 25;

        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;

            Console.Write(totalSeconds - i);

            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;

    }

    public void GetReady()
    {
        Console.Clear();

        Console.WriteLine("Get Ready..");

        ShowSpinner(5);
    }
    public DateTime GetFutureTime(int duration)
    {   
        DateTime futureTime = new DateTime();

        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();

        currentTime = DateTime.Now;

        return currentTime;
    }
}