using System.Collections.Generic;
using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry._date}~|~{entry._entryText}~|~{entry._promptText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();// Replace the current entries
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new[]{"~|~"}, StringSplitOptions.None); //Take a line, find the separator ~|~, and divide the text into “parts.”
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._entryText = parts[1];
            newEntry._promptText = parts[2];

            _entries.Add(newEntry);

        }
    }

}