using System;
using System.Collections.Generic;
using System.IO;

public class BoardGame: Item
{
    protected int maxplayers;
    protected int minplayers;
    
    public BoardGame(string _title, string genre,  int _agemin, int _minplayers, int _maxplayers) : base(_title, _genre, _agemin)
    {
        minplayers = _minplayers;
        maxplayers = _maxplayers;
    }
    public List<BoardGame> NewItem(List<BoardGame> games)
    {
        Console.WriteLine("What is the game's title?");
        string title = Console.ReadLine();
        Console.WriteLine($"What is the minimum recommended age for {title}?");
        string age = Console.ReadLine();
        int agemin = int.Parse(age);
        Console.WriteLine($"How many players should there be minimum to play {title}?");
        string playermin = Console.ReadLine();
        int minplayers = int.Parse(playermin);
        Console.WriteLine("How many players can play maximum?");
        string playermax = Console.ReadLine();
        int maxplayers = int.Parse(playermax);
        string genre = " ";
        BoardGame game = new BoardGame(title, genre,agemin, minplayers, maxplayers);
        games.Add(game);
        return games;
    }
    public void DisplayGames(List<BoardGame> games)
    {
        Console.WriteLine("Your board games are:");
        foreach(BoardGame game in games)
        {
            Console.WriteLine($"Title:{game.title} Genre: {game.genre} Age Minimum: {game.agemin} Players: {game.minplayers} - {game.maxplayers}");
        }
    }
        public List<BoardGame> LoadLibrary(string savefile)
    {
        List<BoardGame> games = new List<BoardGame>();
        return games;
    }
    static void SaveLibrary(List<BoardGame> games, string savefile)
    {
        
    }
    public List<BoardGame> RemoveItem(List<BoardGame> games)
    {
        return games;
    }
}