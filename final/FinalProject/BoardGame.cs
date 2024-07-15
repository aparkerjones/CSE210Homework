using System;

class BoardGame : Game
{
    public BoardGame() : base(){}
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. BoardGame: {title} - {genre} Minimum Age: {agemin} Players {minplayers} - {maxplayers}");
    }
}