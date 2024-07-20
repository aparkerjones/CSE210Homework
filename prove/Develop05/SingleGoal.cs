using System;

class SingleGoal : Goal
{
    public SingleGoal() : base()
    {
        type = "Single";
        Console.WriteLine("How many points should this goal be worth?");
        _pointvalue = Console.ReadLine();
        pointvalue = int.Parse(_pointvalue);
    }
        public SingleGoal(string[] _goal)
    {
        type = _goal[0];
        goalname = _goal[1];
        pointvalue = int.Parse(_goal[2]);
    }
    public override void Display(int i)
    {
        Console.WriteLine($"{i+1}. {goalname} - Worth {pointvalue}");
    }
    public override int Count()
    {
        return 0;
    }
    public override int ResetCount()
    {
        return 0;
    }
    public override void UpCount(){}
    public override string SaveData()
    {
        string data = $"{type}|{goalname}|{pointvalue}";
        return data;
    }
    public override int ResetPoints()
    {
        return 0;
    }
}