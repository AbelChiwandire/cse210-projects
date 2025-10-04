using System;

/*
Enhancement: I added code in the Reflecting Activity to make sure that the program doesnt duplicate questions
            until the list is exhausted.
*/

class Program
{
    static void Main(string[] args)
    {
        bool active = true;

        while (active)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunActivity();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunActivity();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunActivity();
                    break;

                case "4":
                    active = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            if (active)
            {
                Console.WriteLine();
                Console.Clear();
            }
        }
    }
}