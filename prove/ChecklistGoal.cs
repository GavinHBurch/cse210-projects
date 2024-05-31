using System;

public class ChecklistGoal : Goal
{
    private int _bonus;

    private int _target;

    private int _bonus;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target)
    {
        _name = name;

        _description = description;

        _points = points;

        _bonus = bonus;

        _target = target;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");

        string stringChecklisttarget = Console.ReadLine();

        _target = Convert.ToInt32(stringChecklisttarget);

        Console.Write("What is the bonus for accomplishing it that many times? ");

        string bonus = Console.ReadLine();

        _bonus = Convert.ToInt32(bonus);

    }

    public override bool IsComplete() 
    {
        
    }
    
    public override void RecordEvent()
    {
        
    }

    public override void ListGoal()
    {
        string statusSymbol = "";

        bool status = IsComplete();

        if (status == true) {
            statusSymbol = "X";
        } 
        else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_bonus}/{_target}");
    }

    public override string SaveGoal()
    {
        string line = "";

        line = $"ChecklistGoal:" + _name + "," + _description + "," + _points.ToString() + "," + _bonus.ToString() + "," + _target.ToString();
        
        return line;
    }

}