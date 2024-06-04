using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        
        Running running = new Running("June 1, 2024", 60, 6.0);

        activityList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("June 2, 2024", 120, 20);

        activityList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("July 3, 2024", 30, 25);

        activityList.Add(swimming);

        Console.WriteLine("Exercises:");

        Console.WriteLine();

        foreach (Activity activity in activityList) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}