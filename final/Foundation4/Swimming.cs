using System;

class Swimming :Activity{
    private double _laps;
    public Swimming (DateOnly date, double durationInMinutes, int laps):base(date, durationInMinutes, "Swimming"){
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps* 50.0 / 1000.0 * 0.62;
    }
}