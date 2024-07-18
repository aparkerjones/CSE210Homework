using System;
using System.Collections.Generic;
using System.IO;

abstract class Game: Item
{
    public Game() : base()
    {
        Console.WriteLine($"What is the minimum number of players for {title}?");
        string _minplayers = Console.ReadLine();
        minplayers = int.Parse(_minplayers);
        Console.WriteLine($"What is the maximum number of players {title}?");
        string _maxplayers = Console.ReadLine();
        maxplayers = int.Parse(_maxplayers);
    }

    public abstract override void Display(int count);
    
}