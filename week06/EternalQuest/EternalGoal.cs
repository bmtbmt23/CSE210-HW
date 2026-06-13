using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string descrisption, int points)
    {
       
    }
    public override int RecordEvent()
    {
        GetPoints()
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
