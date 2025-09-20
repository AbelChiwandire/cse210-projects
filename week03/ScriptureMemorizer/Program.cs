using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether", 12, 9, 10);
        Scripture scripture = new Scripture(reference, "Wherefore, ye may also have hope, and be partakers of the gift, if ye will but have faith. Behold it was by faith that they of old were called after the holy order of God.");

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