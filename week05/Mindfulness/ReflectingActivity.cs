using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _unusedIndices = new List<int>();
    private readonly Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GenerateRandomPrompt()
    {
        int i = _random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public string GenerateRandomQuestion()
    {
        if (_unusedIndices.Count == 0)
        {
            ResetUnusedIndices();
        }

        int i = _random.Next(0, _unusedIndices.Count);
        int index = _unusedIndices[i];
        _unusedIndices.RemoveAt(i);

        return _questions[index];
    }

    private void ResetUnusedIndices()
    {
        _unusedIndices.Clear();
        for (int i = 0; i < _questions.Count; i++)
        {
            _unusedIndices.Add(i);
        }
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GenerateRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.Write("You begin in: ");
        ShowCountDown(5);

        Console.Clear();

    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{GenerateRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();
    }
}