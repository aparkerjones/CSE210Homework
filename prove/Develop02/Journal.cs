using System;

public class Journal
{
    //public string GetPrompt()
    //{

    //}
    public List<Entry> entries = new List<Entry>();

    public static void NewEntry()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string journalEntry = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry.entry = journalEntry;
        newEntry.date = date;
        entries.Add(newEntry);
    }
    public void DisplayLast()
    {
         if (entries.Count() >= 1)
                {
                    entries[entries.Count()-1].Display();
                }
                else
                {
                    Console.WriteLine("There are no entries yet.");
                }
    }
    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
}