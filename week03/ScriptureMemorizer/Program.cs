using System;

class Program
{
    static void Main(string[] args)
    {
        // EXTRA REQUIREMENT:
        // This program uses a scripture reference and randomly
        // hides only words that have not already been hidden.
        // It hides three words per round to help users memorize
        // the scripture gradually.

        Reference reference = new Reference("John", 3, 16);

        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
    }
}