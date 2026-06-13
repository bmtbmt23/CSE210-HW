using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
   
    publis ChecklistGoal(string name, string description, int point, int target, int bonus)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (!_complete)
        {
            _isComplete = true;
        }
    }
   
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete()? "[x] : []";
        return $"{checkbox} {GetName()} {GetDescription()}"
    }
   
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{Getpoint()};
    }
}
