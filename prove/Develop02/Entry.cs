using System;

public class Entry
{
    public string entry;

    public string date;

    public void Display()
    {
        Console.WriteLine($"{date} - {entry}");
    }

}