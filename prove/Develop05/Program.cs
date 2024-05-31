using System;

string menuSelected = "";

GoalManger goals = new GoalManger();

while (menuSelected != "6")
{

    int points = goals.score();

    Console.WriteLine($"You have {points} points.");
    Console.WriteLine();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Event");
    Console.WriteLine("  6. Quit");
    Console.Write("Select a choice from the menu: ");

    menuSelected = Console.ReadLine();
}
