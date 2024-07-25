public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return _duration;
    }

    public virtual double GetSpeed()
    {
        return _duration;
    }

    public virtual double GetPace()
    {
        return _duration;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MM yyyy")} {GetType().Name} ({_duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles";
    }

}