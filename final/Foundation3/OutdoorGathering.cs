using System;
public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address location, string weather) : base(title, description, date, time, location, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
       return base.StandardDetails()+ $"\nType: Outdoor Gathering\nWeather: {_weather}";
    }
}