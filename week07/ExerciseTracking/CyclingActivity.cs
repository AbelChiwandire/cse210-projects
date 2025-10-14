public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        int minutes = GetLengthInMinutes();

        return (_speed / 60) * minutes;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}