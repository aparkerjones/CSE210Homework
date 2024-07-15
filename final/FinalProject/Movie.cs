using System;
using System.Collections.Generic;
using System.IO;

public class Movie: Item
{
    protected int runtime = 0;

    public Movie() : base()
    {
        Console.WriteLine($"What is the running time of {title}?(in minutes)");
        string time = Console.ReadLine();
        runtime = int.Parse(time);
    }
        public override void Display(int count)
    {
        Console.WriteLine($"{count}. Movie: {title} - {genre} Minimum Age: {agemin} Runtime: {runtime} minutes");
    }
}