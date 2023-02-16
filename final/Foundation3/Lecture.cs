using System;
public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address location, string speakerName, int capacity) : base(title, description, date, time, location, "Lecture")
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return base.StandardDetails() + $"\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}