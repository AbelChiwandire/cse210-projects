public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        int minutes = GetLengthInMinutes();

        return (_distance / minutes) * 60;
    }

    public override double GetPace()
    {
        int minutes = GetLengthInMinutes();

        return minutes / _distance;
    }
}