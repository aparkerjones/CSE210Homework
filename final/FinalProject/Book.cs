using System;
using System.Collections.Generic;
using System.IO;

class Book: Item
{
    protected string author;
    public Book() : base()
    {
        minplayers = 1;
        maxplayers = 1;
        type = "Book";
        Console.WriteLine($"Who is the author of {title}?");
        author = Console.ReadLine();
    }
    public Book(string[] items) : base()
    {
        minplayers = 1;
        maxplayers = 1;
        type = "Book";
        title = items[1];
        author = items[2];
        genre = items[3];
        agemin = int.Parse(items[4]);
        maxplayers = int.Parse(items[5]);
        minplayers = int.Parse(items[6]);
    }
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. Book: {title}: {author} - {genre} - Minimum Age: {agemin}");
    }
    public override string SaveData()
    {
        return $"Book|{title}|{author}|{genre}|{agemin}|{maxplayers}|{minplayers}";
    }

}
