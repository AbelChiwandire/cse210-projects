using System;

// Entry class to display formatted entries.
public class Entry
{
    public DateTime _currentTime = DateTime.Now;
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_currentTime.ToShortDateString()} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}