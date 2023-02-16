using System;
public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _location;
    private string _type;
    public Event(string title, string description, DateOnly date, TimeOnly time, Address location, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _location = location;
        _type = type;
    }

    public string StandardDetails()
    {
        return $"What: {_title}: {_description}\nWhen: {_date.ToLongDateString()} at {_time.ToShortTimeString()}\nWhere: {_location.ToString()}";
    }

    public string ShortDetails()
    {
        return $"Event Type: {_type}\nWhat: {_title}\nWhen: {_date.ToLongDateString()}";
    }

    public abstract string FullDetails();


}