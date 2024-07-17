using System;
using System.Collections.Generic;
using System.IO;

class Shelf
{
    private List<Item> shelf;
    public Shelf(string savefile)
    {
        shelf = [];
        try
        {
            List<string> _shelf = [.. File.ReadAllLines(savefile)];
            foreach(string item in _shelf)
            {
                string[] _item = item.Split("|");  
                switch (_item[0])
                {
                    case "Book":
                        shelf.Add(new Book(_item));
                        break;
                    case "Movie":
                        shelf.Add(new Movie(_item));
                        break;
                    case "BoardGame":
                        shelf.Add(new BoardGame(_item));
                        break;
                    case "VideoGame":
                        shelf.Add(new VideoGame(_item));
                        break;
                }
                    
            }
        }
        catch(Exception)
        {
            Console.WriteLine($"The file {savefile} does not exist. Creating a new digital shelf now.");
            File.Create(savefile);
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
        DisplayShelf();
        Console.WriteLine("Which item do you want to remove?(type it's number and press enter)");
        string _remove = Console.ReadLine();
        int remove = int.Parse(_remove);
        shelf.RemoveAt(remove-1);
    }
    public void DisplayShelf()
    {
        for(int count =1; count - 1 < shelf.Count; count++)
        {
            shelf[count-1].Display(count);
        }
        Thread.Sleep(5000);
    }
    public void SaveShelf(string _savefile)
    {
        string savefile = _savefile;
        using StreamWriter file = new(savefile, false);
        {
            foreach (var item in shelf)
            {
                file.WriteLine(item.SaveData());
            }
        }
        Thread.Sleep(1000);
        Console.WriteLine("Digital BookShelf Saved");
    }
}