
using System;
using System.IO;

public class Journal
{
    // All journal entries should be stored in a list
    public List<Entry> _entries = new List<Entry>();

    // List of journal prompts
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?",
        "If I could change anything today, what would it be?",
        "What is something new I learned today?",
        "What am I most grateful for today?"
    };

    // Add a new journal entry
    public void AddEntry()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");

        string response = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(response))
        {
            Console.WriteLine("Your response cannot be empty.");
            return;
        }

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(date, prompt, response);

        _entries.Add(newEntry);

        Console.WriteLine("Journal entry added successfully!");
    }

    // Display all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saving journal entries to a file
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    // Loading journal entries from a file
    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry(
                    parts[0],
                    parts[1],
                    parts[2]
                );

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }

    // Display the total number of entries
    public void DisplayEntryCount()
    {
        Console.WriteLine($"Total journal entries: {_entries.Count}");
    }
}
