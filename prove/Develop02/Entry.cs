using System;

public class Entry
{
    public string entry;

    public string date;

    public static void NewEntry(List<Entry> entries)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string journalEntry = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry.entry = journalEntry;
        newEntry.date = date;
        entries.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine($"{date} - {entry}");
    }

}