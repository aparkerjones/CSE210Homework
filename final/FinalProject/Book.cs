using System;
using System.Collections.Generic;
using System.IO;

public class Book: Item
{
    protected string author;

    public Book(string _title, string _genre, int _agemin, string _author) : base(_title, _genre, _agemin)
    {
        agemin = _agemin;
    }
    public List<Book> NewItem(List<Book> books)
    {
        Console.WriteLine("What is the book's title?");
        string title = Console.ReadLine();
        Console.WriteLine($"Who is the author of {title}?");
        string author = Console.ReadLine();
        Console.WriteLine($"What is the genre of {title}?");
        string genre = Console.ReadLine();
        Console.WriteLine($"What is the minimum recommended age for {title}?");
        string age = Console.ReadLine();
        int agemin = int.Parse(age);
        Book book = new Book(title, genre, agemin, author);
        books.Add(book);
        return books;
    }
    public void DisplayBooks(List<Book> books)
    {
        foreach(Book book in books)
        {
            Console.WriteLine($"Title:{book.title} Genre: {book.genre} Age Minimum: {book.agemin}");
        }
    }
        public List<Item> LoadLibrary(string savefile)
    {
        List<Item> items = new List<Item>();
        return items;
    }

    public void SaveLibrary(List<Book> books, string savefile)
    {

    }

    static List<Book> RemoveItem(List<Book> books)
    {
        return books;
    }
}
