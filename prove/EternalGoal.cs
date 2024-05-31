using System;

public class EternalGoal : Goal
{

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _points = 50;
        
    }
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringReprensentation()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _points.ToString();
        return line;
    }

    public override void RecordEvent()
    {
    
    }
}