using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        while (choice != "6")

        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Show Entry Count");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            Console.WriteLine();

            // Perform the selected action
            if (choice == "1")
            {
                journal.AddEntry();
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            else if (choice == "5")
            {
                journal.DisplayEntryCount();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Thank you for using the Journal Program!");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-6.");
            }

        }

    }
}