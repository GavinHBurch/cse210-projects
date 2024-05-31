using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _name = "Name";

        _description = "Description";

        _points = 50;
        
        _status = false;
    }

    public SimpleGoal(string name, string description, int points, bool status)
    {
        _name = name;

        _description = description;

        _points = points;

        _status = status;
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }


    public override string GetStringReprensentation()
    {
        string line = "";

        line = $"SimpleGoal:{_name},{_description}{_points},{IsComplete().ToString()}";

        return line;
    }
}