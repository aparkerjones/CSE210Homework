using System;
using System.Collections.Generic;
using System.IO;

public class Shelf
{
    private string savefile;
    private List<Item> shelf;
    public Shelf(string _savefile)
    {
        shelf = new List<Item>();
        savefile = _savefile;
    }
    public void NewItem()
    {
        string selection;
        int type;
        Console.WriteLine("What kind of entertainment are you removing?");
        Console.WriteLine("1. Book");
        Console.WriteLine("2. Movie");
        Console.WriteLine("3. BoardGame");
        selection = Console.ReadLine();
        type = int.Parse(selection);
        switch(type)
        {
            case 1:
                shelf.Add(new Book());
                break;

            case 2:
                shelf.Add(new Movie());
                break;
            case 3:
                shelf.Add(new BoardGame());
                break;
        }
        
        Console.WriteLine("Adding Item");
        Thread.Sleep(1000);
        Console.WriteLine("Done");
    }
    public void SaveLibrary()
    {

        Console.WriteLine("Digital BookShelf Saved");
    }
    public void RemoveItem()
    {

    }
    public void DisplayShelf()
    {
        for(int count =1; count < shelf.Count()+1; count++)
        {
            shelf[count-1].Display(count);
        }
        Thread.Sleep(5000);
    }
    public void SaveShelf()
    {
        string selection;
        int type;
        Console.WriteLine("Which library do you want to save?");
        Console.WriteLine("0. All Libaries");
        Console.WriteLine("1. Books");
        Console.WriteLine("2. Movies");
        Console.WriteLine("3. Board Games");
        selection = Console.ReadLine();
        type = int.Parse(selection);
    }
}