 /*
Author: Abel Chiwandire
Purpose: This is a Journal Program. Created to motivate people to write in their journals often.
Enhancements: Added a Search class that has - SearchByDate() and - SearchByKeyword() methods so
              the user can retrieve specific entries from their journal.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create PromptGenerator instance
        PromptGenerator myPrompt = new PromptGenerator();

        // Create Journal instance
        Journal myJournal = new Journal();

        // Create Search instance
        Search mySearch = new Search();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";
        string fileName = "";

        while (choice != "6")
        {
            // Display menu options
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry myEntry = new Entry();
                    string prompt = myPrompt.GeneratePrompt();
                    Console.WriteLine(prompt);
                    myEntry._entryText = Console.ReadLine();
                    myEntry._promptText = prompt;
                    myJournal.AddEntry(myEntry);
                    break;

                case "2":
                    if (myJournal._entries.Count == 0)
                    {
                        Console.WriteLine("No entries to display");
                    }
                    else
                    {
                        foreach (var log in myJournal._entries)
                        {
                            log.Display();
                            Console.WriteLine();
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("What is the filename?");
                    fileName = Console.ReadLine();
                    myJournal.LoadFromFile(fileName);
                    break;

                case "4":
                    Console.WriteLine("What is the filename?");
                    fileName = Console.ReadLine();
                    myJournal.SaveToFile(fileName);
                    break;

                case "5":
                    Console.WriteLine("1. Search by date.");
                    Console.WriteLine("2. Search by keyword.");
                    Console.Write("Enter preferred search method: ");
                    string pref = Console.ReadLine();
                    if (pref == "1")
                    {
                        Console.Write("Enter the date in the following format (yyyy-MM-dd): ");
                        string stringDate = Console.ReadLine();
                        DateTime date = DateTime.Parse(stringDate);

                        var results = mySearch.SearchByDate(myJournal, date);
                        if (results.Count == 0)
                        {
                            Console.WriteLine("No entries found for that date!");
                        }
                        else
                        {
                            foreach (var entry in results)
                            {
                                entry.Display();
                                Console.WriteLine();
                            }
                        }                        
                    }
                    else if (pref == "2")
                    {
                        Console.Write("Enter the keyword: ");
                        string keyword = Console.ReadLine();
                        var results = mySearch.SearchByKeyword(myJournal, keyword);
                        if (results.Count == 0)
                        {
                            Console.WriteLine("No entries found containing that keyword!");
                        }
                        else
                        {
                            foreach (var entry in results)
                            {
                                entry.Display();
                                Console.WriteLine();
                            }
                        }                    
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again! (1 or 2)");
                    }
                    break;

                case "6":
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again! (1-6)");
                    break;
            }
        }      
    }
}