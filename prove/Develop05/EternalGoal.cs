using System;

public class EternalGoal: Goal
{

    public EternalGoal(String name, String description, int score) : base(name, description, score, 0)
    {
    }

    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override void DoGoal()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return false;
    }
}