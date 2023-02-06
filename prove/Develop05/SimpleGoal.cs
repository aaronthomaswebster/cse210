using System;

public class SimpleGoal:Goal{
    private int _completionBonus;

    public SimpleGoal(String name, String description, int score, int completionBonus): base(name, description, score, completionBonus)
    {
       
        _name = name;
        _description = description;
        _score = score;
        _completionBonus = completionBonus;
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