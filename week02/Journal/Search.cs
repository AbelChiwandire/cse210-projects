using System;

// Search class to search journal entries.
public class Search
{
    public List<Entry> SearchByDate(Journal journal, DateTime date)
    {
        List<Entry> _results = new List<Entry>();

        foreach (var entry in journal._entries)
        {
            if (entry._currentTime.Date == date.Date)
            {
                _results.Add(entry);
            }
        }

        return _results;
    }

    public List<Entry> SearchByKeyword(Journal journal, string keyword)
    {
        List<Entry> _results = new List<Entry>();

        foreach (var entry in journal._entries)
        {
            if (entry._entryText.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                _results.Add(entry);
            }
        }

        return _results;
    }
}