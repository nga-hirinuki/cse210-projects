using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) //method to add entries to the list

    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() //display entry
    {
        foreach (var entry in _entries)
        {
            entry.Display(); // using Entry.cs Display method for formatting
            Console.WriteLine(); //Add spacing for clarity
        }
    }

    public void SaveToFile(string fileName) // save file method
    {
        using (StreamWriter writer = new StreamWriter(fileName)) //create a .txt file
        {
            foreach (var entry in _entries) // every entry made save in this format
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
        Console.WriteLine($"Entries successfully saved to {fileName}.");// message to let user know entry is saved
    }

    public void LoadFromFile(string fileName) // retrieve file
    {
        if (!File.Exists(fileName)) // wrong file name
        {
            Console.WriteLine("File not found. Please try again.");
            return;
        }
        _entries.Clear(); // start again

        using (StreamReader reader = new StreamReader(fileName)) // if found
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }
    }
}
