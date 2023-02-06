using System;

public abstract class ListGoal: Goal{

    public ListGoal(String name, String description, int score, int completionBonus): base(name, description, score, completionBonus)
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
        throw new NotImplementedException();
    }
    
}