using System;

class Running:Activity{
    private double _distance;
    public Running(DateOnly date, double durationInMinutes, double distance):base(date, durationInMinutes, "Running" ){
        this._distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }
}