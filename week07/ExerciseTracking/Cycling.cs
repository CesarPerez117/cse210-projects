using System;

public class Cycling : Activity
{
    private double _distance;
    public Cycling(string activity, string date, int minutes, double distance): base(activity, date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double CalculateSpeedKmh()
    {
        return (GetDistance() / GetMinutes() * 60);
    }
    public override double CalculatePace()
    {
        return GetMinutes() / GetDistance();
    }
    public override string DisplaySummary()
    {
        return base.DisplaySummary();
    }
}