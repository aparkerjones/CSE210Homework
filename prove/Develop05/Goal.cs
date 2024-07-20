using System;

abstract class Goal
{
    protected int count;
    protected string type;
    protected int pointvalue;
    protected string goalname;
    protected string _pointvalue;
    public Goal()
    {
        count = 0;
        Console.WriteLine("What is the goal?");
        goalname = Console.ReadLine();
    }
    public abstract void Display(int i);
    public string Type()
    {
        return type;
    }
    public int PointValue()
    {
        return pointvalue;
    }
    public abstract int Count();
    public abstract int ResetCount();
    public abstract void UpCount();
    public abstract string SaveData();
    public abstract int ResetPoints();
}