using System;
using System.Collections.Generic;

/*
ProgramGenerator class to generate random prompts
*/
public class PromptGenerator
{
    private readonly Random _random = new Random();
    private readonly List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    private List<int> _unusedIndices = new List<int>();

    private void Initializer()
    {
        ResetUnusedIndices();
    }

    public string GeneratePrompt()
    {
        if (_unusedIndices.Count == 0)
        {
            ResetUnusedIndices();
        }

        int i = _random.Next(0, _unusedIndices.Count);
        int index = _unusedIndices[i];
        _unusedIndices.RemoveAt(i);

        return _prompts[index];
    }

    private void ResetUnusedIndices()
    {
        _unusedIndices.Clear();
        for (int i = 0; i < _prompts.Count; i++)
        {
            _unusedIndices.Add(i);
        }
    }
}