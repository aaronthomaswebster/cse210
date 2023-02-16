using System;

class Cycling:Activity{
    private double _speed;
    public Cycling(DateOnly date, double durationInMinutes, double speed):base(date, durationInMinutes, "Cycling" ){
        this._speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

}