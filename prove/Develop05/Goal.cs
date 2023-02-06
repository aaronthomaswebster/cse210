using System;

public abstract class Goal{

    private String _name;
    private String _description;
    private int _completionScore;

    public Goal(String name, String description, int score, int completionScore){
        _name = name;
        _description = description;
        _completionScore = completionScore;
    }
    
    public abstract void Display();

   public abstract void DoGoal();

   public abstract bool IsComplete();
}