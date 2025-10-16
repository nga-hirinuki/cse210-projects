using System;
public class Swimming : Activity
{
    private double _laps;

     public Swimming(DateTime date, int length, double laps ) : base(date, length)
    {
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        double distanceMeter = _laps * 50;
        double distanceKm = distanceMeter / 1000;
        return distanceKm;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
}