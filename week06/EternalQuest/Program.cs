// Enhancement: Added a deadline concept by adding a DueDate class to keep tracks of the completion date.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}