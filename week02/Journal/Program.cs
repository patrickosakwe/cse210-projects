
using System;


// Creativity and Exceeding Requirements:
// 1. I added an Entry Count feature to allow users
//    to see the total number of journal entries.

// 2. I included eight different random journal prompts
//    to make the journaling experience more interesting.

// 3. I prevent users from submitting empty journal responses.
class Program
{
    static void Main(string[] args)
    {
        // Create the objects 
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

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

            if (choice == "1")
            {
                // Get a random prompt
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                // Get the user's response
                string response = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Your response cannot be empty.");
                }
                else
                {
                    // Get current date
                    string date = DateTime.Now.ToShortDateString();

                    // Create a new Entry 
                    Entry anEntry = new Entry(date, prompt, response);

                    // Add the entry to the Journal
                    journal.AddEntry(anEntry);

                    Console.WriteLine("Journal entry added successfully!");
                }
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
