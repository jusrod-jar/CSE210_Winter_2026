using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void WriteEntry()
    {
        Entry newEntry = new Entry();
        Prompt promptGen = new Prompt();

        newEntry._currentDate = DateOnly.FromDateTime(DateTime.Now);
        newEntry._prompt = promptGen.GetPrompt();

        Console.WriteLine(newEntry._prompt);
        Console.Write("> ");
        newEntry._response = Console.ReadLine();

        _entries.Add(newEntry);

        Console.WriteLine();
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the filename you would like to load? ");
        string filename = Console.ReadLine();
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry loaded = new Entry();

            loaded._currentDate = DateOnly.Parse(parts[0]);
            loaded._prompt = parts[1];
            loaded._response = parts[2];

            _entries.Add(loaded);

        }
        Console.WriteLine();
    }

    public void SaveJournal()
    {
        Console.WriteLine("What would you like to save this journal as? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._currentDate}~{entry._prompt}~{entry._response}");
            }
        }
        Console.WriteLine();
    }
    public void Motivation()
    {
        Prompt promptGen = new Prompt();
        Console.WriteLine(promptGen.GetMotivation());

        Console.WriteLine();
    }
}