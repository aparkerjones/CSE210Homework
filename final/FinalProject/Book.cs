using System;
using System.Collections.Generic;
using System.IO;

public class Book: Item
{
    protected string author;

    public Book() : base()
    {
        Console.WriteLine($"Who is the author of {title}?");
        author = Console.ReadLine();
    }
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. Book: {title}: {author} - {genre} Minimum Age: {agemin}");
    }
}
