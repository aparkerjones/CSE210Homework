using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string savefilebooks = "booklibrary.csv";
        string savefilemovies = "movielibrary.csv";
        string savefilegames = "gamelibrary.csv";
        string selection;
        List<Item> bookLib = new List<Item>();
        List<Item> movieLib = new List<Item>();
        List<Item> gameLib = new List<Item>();
        int type;
        bookLib = Book.LoadLibrary(savefilebooks, bookLib);
        movieLib = Movie.LoadLibrary(savefilemovies);
        gameLib = BoardGame.LoadLibary(savefilegames);
        int end = 0;
        Console.WriteLine("Welcome to your home library management system.");
        while(end != 1)
        {
        
            List<string> options = new List<string> {"Add New Item", "Delete Item", "Display Library", "Save to File", "Discard Changes", "Exit"};
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Menu:");
            int i=1;
            foreach (string option in options )
            {
                Console.WriteLine($"{i}. {option}");
            }
            Console.WriteLine("Please enter the number of your choice from the menu");
            string choice = Console.ReadLine();
            int num = int.Parse(choice);
            switch(num)
            {
                case 1:
                    Console.WriteLine("What kind of entertainment are you adding?");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Movie");
                    Console.WriteLine("3. BoardGame");
                    selection = Console.ReadLine();
                    type = int.Parse(selection);
                    if(type == 1)
                    {
                        bookLib = Book.NewItem(bookLib);
                    }
                    else if (type == 2)
                    {
                        movieLib = Movie.NewItem(movieLib);
                    }
                    else{
                        gameLib = BoardGame.NewItem(gameLib);
                    }
                    Console.WriteLine("Adding New Item");
                    Thread.Sleep(1000);
                    Console.WriteLine("Done");
                    break;
                case 2:
                    Console.WriteLine("What kind of entertainment are you removing?");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Movie");
                    Console.WriteLine("3. BoardGame");
                    selection = Console.ReadLine();
                    type = int.Parse(selection);
                    if(type == 1)
                    {
                        bookLib = Book.RemoveItem(bookLib);
                    }
                    else if (type == 2)
                    {
                        movieLib = Movie.RemoveItem(movieLib);
                    }
                    else{
                        gameLib = BoardGame.RemoveItem();
                    }
                    Console.WriteLine("Removing Item");
                    Thread.Sleep(1000);
                    Console.WriteLine("Done");
                    break;
                case 3:
                    Console.WriteLine("Which library do you want to print?");
                    Console.WriteLine("0. All Libaries");
                    Console.WriteLine("1. Books");
                    Console.WriteLine("2. Movies");
                    Console.WriteLine("3. Board Games");
                    selection = Console.ReadLine();
                    type = int.Parse(selection);
                    switch(type)
                    {
                        case 0:
                            Book.DisplayBooks(bookLib);
                            Movie.DisplayMovies(movieLib);
                            BoardGame.DisplayGames(gameLib);
                            break;
                        case 1:
                            Book.DisplayBooks(bookLib);
                            break;
                        case 2:
                            Movie.DisplayMovies(movieLib);
                            break;
                        case 3:
                            BoardGame.DisplayGames(gameLib);
                            break;
                    }

                    break;
                case 4:
                    Console.WriteLine("Which library do you want to save?");
                    Console.WriteLine("0. All Libaries");
                    Console.WriteLine("1. Books");
                    Console.WriteLine("2. Movies");
                    Console.WriteLine("3. Board Games");
                    selection = Console.ReadLine();
                    type = int.Parse(selection);
                    switch(type)
                    {
                        case 0:
                            Book.SaveLibrary(bookLib, savefilebooks);
                            Movie.SaveLibrary(movieLib, savefilemovies);
                            BoardGame.SaveLibrary(gameLib, savefilegames);
                            break;
                        case 1:
                            Book.SaveLibrary(bookLib, savefilebooks);
                            break;
                        case 2:
                            Movie.SaveLibrary(movieLib, savefilemovies);
                            break;
                        case 3:
                            BoardGame.SaveLibrary(gameLib, savefilegames);
                            break;
                    }
                    break;
                case 5:
                    break;
                case 6:
                    end = 1;
                    break;
                    
            }
        
        
        }
        
    }
}