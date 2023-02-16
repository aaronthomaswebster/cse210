using System;
public class Reception : Event
{
    private string _RSVPEmail;
    public Reception(string title, string description, DateOnly date, TimeOnly time, Address location, string rsvpEmail)
        : base(title, description, date, time, location, "Reception")
    {
        _RSVPEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return base.StandardDetails() + $"\nType: Reception\nRSVP Email: {_RSVPEmail}";
    }


}