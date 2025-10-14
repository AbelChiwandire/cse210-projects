using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity(new DateTime(2025, 10, 14), 30, 5);
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2025, 10, 13), 45, 15);
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2025, 10, 12), 33, 7);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        } 

    }
}