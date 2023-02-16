using System;

class Activity
{
    protected DateOnly _date;
    protected double _durationInMinutes;
    private string _activityType;
    public Activity(DateOnly date, double duration, string activityType)
    {
        _date = date;
        _durationInMinutes = duration;
        _activityType = activityType;
    }

    public virtual double Distance()
    {
        return Speed() * _durationInMinutes/60.0;
    }

    public virtual double Speed()
    {
        return Distance() /(_durationInMinutes/60.0);
    }


    public virtual double Pace()
    {
        return _durationInMinutes / Distance();
    }

    public string Summary(){
        return $"{_date:dd MMM yyyy} {_activityType} ({_durationInMinutes} min)- Distance {Distance():0.0} miles, Speed {Speed():0.0} mph, Pace: {Pace():0.0} min per mile";
    }
}