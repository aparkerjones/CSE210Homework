using System;

class VideoGame : Game
{
    string console;
    public VideoGame() : base()
    {
        Console.WriteLine($"What console is {title} played on?");
        console = Console.ReadLine();
    }
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. VideoGame: {title} - {genre} Console: {console} Minimum Age: {agemin} Players {minplayers} - {maxplayers}");
    }
}