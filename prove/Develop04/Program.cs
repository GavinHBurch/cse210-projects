using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        int BreathingActvityLog = 0;

        int ReflectingActivityLog = 0;

        int ListingActivityLog = 0;



        while (input != "4")
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program");

            Console.WriteLine("Menu Options:");

            Console.WriteLine("1. Start breathing activity");

            Console.WriteLine("2. Start reflecting activity");

            Console.WriteLine("3. Start listing activity");

            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity to do: ");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":

                    BreathingActivity breathingActivity = new BreathingActivity();

                    breathingActivity.Run();

                    breathingActivity.PromptBreathing();

                    breathingActivity.StopActivity();

                    BreathingActvityLog++;

                    break;

                case "2":

                    ReflectingActivity reflectingActivity = new ReflectingActivity();

                    reflectingActivity.Run();

                    reflectingActivity.DisplayPrompt();

                    reflectingActivity.StopActivity();

                    ReflectingActivityLog++;

                    break;

                case "3":

                    ListingActivity listingActivity = new ListingActivity();

                    listingActivity.Run();

                    listingActivity.PromptListing();

                    listingActivity.StopActivity();

                    ListingActivityLog++;
                    
                    break;

                case "4":

                    Environment.Exit(0);

                    break;
            }
        }
        Environment.Exit(0);
    }
}