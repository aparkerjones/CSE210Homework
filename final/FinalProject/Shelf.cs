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
        using (File.Exists(savefile) ? File.AppendText(savefile) : new StreamWriter(savefile))
        {

        }
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
            case 4:
                shelf.Add(new VideoGame());
                break;
        }
        
        Console.WriteLine("Adding Item");
        Thread.Sleep(1000);
        Console.WriteLine("Done");
    }
    public void RemoveItem()
    {

    }
    public void DisplayShelf()
    {
        for(int count =1; count - 1 < shelf.Count(); count++)
        {
            shelf[count-1].Display(count);
        }
        Thread.Sleep(5000);
    }
    public void SaveShelf(string _savefile)
    {
        savefile = _savefile;
        using (File.Exists(savefile) ? File.AppendText(savefile) : new StreamWriter(savefile))
        {
            
        }
        Console.WriteLine("Digital BookShelf Saved");
    }
}