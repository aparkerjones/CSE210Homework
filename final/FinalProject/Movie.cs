using System;
using System.Collections.Generic;
using System.IO;

class Movie: Item
{
    protected int runtime = 0;
    public Movie() : base()
    {
        minplayers = 1;
        maxplayers = 100;
        type = "Movie";
        Console.WriteLine($"What is the running time of {title}?(in minutes)");
        string time = Console.ReadLine();
        runtime = int.Parse(time);
    }
        public Movie(string[] items) : base(items)
    {
        type = "Movie";
        title = items[1];
        genre = items[2];
        agemin = int.Parse(items[3]);
        runtime = int.Parse(items[4]);
        maxplayers = int.Parse(items[5]);
        minplayers = int.Parse(items[6]);
    }
        public override void Display(int count)
    {
        Console.WriteLine($"{count}. Movie: {title} - {genre} - Minimum Age: {agemin} Runtime: {runtime} minutes");
    }
        public override string SaveData()
    {
        return $"Movie|{title}|{genre}|{agemin}|{runtime}|{maxplayers}|{minplayers}";
    }
}