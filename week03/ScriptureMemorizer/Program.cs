using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only Son.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter to continue or type 'hint' to reveal some hidden words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();
            switch (input)
            {
                case "quit":
                    return;
                case "hint":
                    scripture.RevealWords(2);
                    break;
                default:
                    scripture.HideRandomWords(2);
                    break;
            }
        }
    }           
}