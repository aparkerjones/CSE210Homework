using System;
using System.Collections.Generic;
using System.IO;

public class BoardGame: Item
{
    protected int maxplayers;
    protected int minplayers;
    
    public BoardGame() : base()
    {
        Console.WriteLine("What is the minimum number of players?");
        string _minplayers = Console.ReadLine();
        minplayers = int.Parse(_minplayers);
        Console.WriteLine("What is the maximum number of players?");
        string _maxplayers = Console.ReadLine();
        maxplayers = int.Parse(_maxplayers);
    }

        public override void Display(int count)
    {
        Console.WriteLine($"{count}. BoardGame: {title} - {genre} Minimum Age: {agemin} Players {minplayers} - {maxplayers}");
    }
    
}