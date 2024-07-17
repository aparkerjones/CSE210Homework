using System;

class BoardGame : Game
{
    public BoardGame() : base()
    {
        type = "BoardGame";
    }
    public BoardGame(string[] items) : base()
    {
        title = items[1];
        genre = items[2];
        agemin = int.Parse(items[3]);
        minplayers = int.Parse(items[4]);
        maxplayers = int.Parse(items[5]);
    }
    public override void Display(int count)
    {
        Console.WriteLine($"{count}. BoardGame: {title} - {genre} Minimum Age: {agemin} Players {minplayers} - {maxplayers}");
    }
        public override string SaveData()
    {
        return $"BoardGame|{title}|{genre}|{agemin}|{minplayers}|{maxplayers}";
    }
}