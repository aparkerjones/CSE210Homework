using System;

class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
        type = "Eternal";
        Console.WriteLine("How many points should you get every time you complete this goal?");
        _pointvalue = Console.ReadLine();
        pointvalue = int.Parse(_pointvalue);

    }
    public EternalGoal(string[] _goal)
    {
        type = _goal[0];
        goalname = _goal[1];
        pointvalue = int.Parse(_goal[2]);
    }
    public override void Display(int i)
    {
        Console.WriteLine($"{i+1}. {goalname} - Worth {pointvalue}");
    }
    public override string SaveData()
    {
        string data = $"{type}|{goalname}|{pointvalue}|{count}";
        return data;
    }
    public override void UpCount()
    {
        count ++;
    }
    public override int Count()
    {
        return 0;
    }
    public override int ResetCount()
    {
        return 0;
    }
        public override int ResetPoints()
    {
        return 0;
    }
}