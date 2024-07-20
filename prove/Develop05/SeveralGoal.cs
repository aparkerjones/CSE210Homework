using System;

class SeveralGoal : Goal
{
    int resetcount;
    int resetpoints;
    public SeveralGoal() : base()
    {
        type = "Several";
        Console.WriteLine("How many points should you get every time you complete a goal?");
        _pointvalue = Console.ReadLine();
        pointvalue = int.Parse(_pointvalue);
        resetpoints = pointvalue*10;
        Console.WriteLine("How many times do you want to complete your goal");

    }
    public SeveralGoal(string[] _goal) : base()
    {
        type = _goal[0];
        goalname = _goal[1];
        pointvalue = int.Parse(_goal[2]);
        count = int.Parse(_goal[3]);
        resetpoints = pointvalue * 10;
        resetcount = int.Parse(_goal[4]);
    }
    public override void Display(int i)
    {
        Console.WriteLine($"{i+1}. {goalname} - {count}/{resetcount} - Worth {pointvalue}");
    }
    public override int Count()
    {
        return count;
    }
    public override int ResetCount()
    {
        return resetcount;
    }
    public override void UpCount()
    {
        count++;
    }
    public override int ResetPoints()
    {
        return resetpoints;
    }
    public override string SaveData()
    {
        string data = $"{type}|{goalname}|{pointvalue}|{count}|{resetcount}";
        return data;
    }
}