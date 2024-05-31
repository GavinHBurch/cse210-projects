using System;

public class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal() 
    {
        _shortName = "Name";

        _description = "Description";

        _points = 50;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;

        _description = description;

        _points = points;
    }

    protected void ChecklistGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        
        Console.Write("What is a description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringpoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringpoints);

    }

    public virtual string GetDetailsString()
    {
        string line = "";
        return line;
    }


    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }
}