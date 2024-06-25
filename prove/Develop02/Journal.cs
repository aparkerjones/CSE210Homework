using System;

public class Journal
{
    

    
    public void DisplayLast(List<Entry> entries)
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
    public void DisplayAll(List<Entry> entries)
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
}