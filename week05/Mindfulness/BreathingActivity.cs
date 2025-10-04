using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

            // new sequence
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}