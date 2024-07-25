public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        double _duration = base.GetSpeed();
        double _speed = (GetDistance() / _duration) * 60;

        return _speed;
    }

    public override double GetPace()
    {
        double _duration = base.GetPace();
        double _pace = _duration / GetDistance();

        return _pace;
    }

}