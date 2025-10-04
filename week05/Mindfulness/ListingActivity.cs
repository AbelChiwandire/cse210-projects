using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private readonly Random _random = new Random();
    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GenerateRandomPrompt()
    {
        int i = _random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            entries.Add(entry);
        }

        _count = entries.Count;

        return entries;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GenerateRandomPrompt()} ---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
}