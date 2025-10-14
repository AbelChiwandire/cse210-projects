public class SwimmingActivity : Activity
{
    private int _lapsNum;

    public SwimmingActivity(DateTime date, int lengthInMinutes, int lapsNum)
        : base(date, lengthInMinutes)
    {
        _lapsNum = lapsNum;
    }

    public override double GetDistance()
    {
        return _lapsNum * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        int minutes = GetLengthInMinutes();

        return (distance / minutes) * 60;
    }

    public override double GetPace()
    {
        double speed = GetSpeed();

        return 60 / speed;
    }

    public override string GetSummary()
    {
        DateTime date = GetDateTime();
        int minutes = GetLengthInMinutes();

        return $"{date:dd MMM yyyy} {this.GetType().Name} ({minutes} min) - Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km, Number of laps: {_lapsNum} laps.";
    }
}
