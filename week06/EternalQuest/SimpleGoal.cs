using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
   
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }
   
    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return Getpoints();
        }
        return 0;
    }
   
    public override string GetStringRepresantation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}
