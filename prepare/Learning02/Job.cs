using System;

public class Job
{
    public string Title;
    public string employer;
    public int startYear;
    public int endYear;

    public void Display()
    {
        Console.WriteLine($"{Title} ({employer}) {startYear}-{endYear}");
    }
}