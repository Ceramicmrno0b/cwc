using System;
using System.Collections.Generic;

// Base Activity class
public class Activity
{
    private DateTime date;
    public int length; // in minutes

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} ";
    }
}

// Derived Classes
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / base.length * 60; // kilometers per hour
    }

    public override double GetPace()
    {
        return base.length / distance; // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({base.length} min) - Distance {distance} kilometers, Speed {GetSpeed()} kph, Pace: {GetPace()} min per kilometer";
    }
}

public class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Stationary Bicycles ({base.length} min) - Speed {speed} kph";
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 0.05; // 50 meters per lap
    }

    public override double GetSpeed()
    {
        return (laps * 0.05) / base.length * 60 * 60; // kilometers per hour
    }

    public override double GetPace()
    {
        return base.length / (laps * 0.05); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({base.length} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 7), 30, 3.0));
        activities.Add(new StationaryBicycles(new DateTime(2022, 11, 4), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 60, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
