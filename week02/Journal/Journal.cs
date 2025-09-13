using System;
using System.IO;
using System.Collections.Generic;

/*
Journal class to store entries.
Has SaveToFile() and LoadFromFile() methods
*/
public class Journal
{
    // field
    public List<Entry> _entries = new List<Entry>();
    // methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry._currentTime);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 3)
        {
            if (i + 2 < lines.Length)
            {
                Entry e = new Entry();
                e._currentTime = DateTime.Parse(lines[i]);
                e._promptText = lines[i + 1];
                e._entryText = lines[i + 2];

                AddEntry(e);
            }
        }
    }
}