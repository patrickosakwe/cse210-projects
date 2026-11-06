
using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    // Store all journal entries
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
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

    // Save journal entries to a file
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

    // Load journal entries from a file
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

    // Display total number of entries
    public void DisplayEntryCount()
    {
        Console.WriteLine($"Total journal entries: {_entries.Count}");
    }
}
