public class Running : Activity
{
    public double _distance;
    
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double _duration = base.GetSpeed();
        double _speed = (_distance / _duration) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        double _duration = base.GetPace();
        double _peace = _duration / _distance;
        return _peace;
    }

    

}