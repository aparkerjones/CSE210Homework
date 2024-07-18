using System;

class VideoGame : Game
{
    private string console;
    public VideoGame() : base()
    {
        type = "VideoGame";
        Console.WriteLine($"What console is {title} played on?");
        console = Console.ReadLine();
    }
    
    public VideoGame(string[] items) : base()
    {
        type = "VideoGame";
        title = items[1];
        genre = items[2];
        agemin = int.Parse(items[3]);
        minplayers = int.Parse(items[4]);
        maxplayers = int.Parse(items[5]);
        console = items[6];
    }
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. VideoGame: {title} - {genre} - Console: {console} Minimum Age: {agemin} Players {minplayers} - {maxplayers}");
    }
    public override string SaveData()
    {
        return $"VideoGame|{title}|{genre}|{agemin}|{minplayers}|{maxplayers}|{console}";
    }
}