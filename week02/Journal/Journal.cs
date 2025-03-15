using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    // Add a new entry 
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    // Display all entries
    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in Entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save the journal
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Load the journal
    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entries.Add(new Entry(prompt, response, date));
        }
    }
}
