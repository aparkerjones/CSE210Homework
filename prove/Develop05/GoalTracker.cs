using System;
using System.Collections.Generic;
using System.IO;
class GoalTracker
{
    int points;
    List<Goal> goals = new List<Goal>();
    string savefile = "goals.txt";
    public GoalTracker()
    {
        try
        {
            List<string> _goals = [.. File.ReadAllLines(savefile)];

            for(int count = 0; count < goals.Count; count++)
            {
                if(count == 0)
                {
                    points = int.Parse(_goals[0]);
                }
                else
                {
                    string[] goal = _goals[count].Split("|");
                    switch (goal[0])
                    {
                        case "Several":
                            goals.Add(new SeveralGoal(goal));
                            break;
                        case "Single":
                            goals.Add(new SingleGoal(goal));
                            break;
                        case "Eternal":
                            goals.Add(new EternalGoal(goal));
                            break;
                    }
                }
            }
        }
        catch(Exception)
        {
            Console.WriteLine($"The file {savefile} does not exist. Creating a new Goal Tracker File");
            File.Create(savefile);
            points = 0;
        }
    }
    public void CompleteGoal()
    {
        DisplayGoals();
        Console.WriteLine("Which goal did you complete?");
        string _goal = Console.ReadLine();
        int goal = int.Parse(_goal);
        string type = goals[goal].Type();
        
        switch(type)
        {
            case "Single":
                points += goals[goal].PointValue();
                goals.RemoveAt(goal-1);
                break;
            case "Several":
                goals[goal].UpCount();
                if (goals[goal].Count() < goals[goal].ResetCount())
                {
                    points += goals[goal].PointValue();
                }
                else
                {
                    points += goals[goal].ResetPoints();
                    Console.WriteLine($"You finished all {goals[goal].ResetCount()}/goals[goal].ResetCount() times");
                    goals.RemoveAt(goal-1);
                }
                break;
            case "Eternal":
                goals[goal].UpCount();
                points += goals[goal].PointValue();
                break;
        }
    }
    public void DisplayGoals()
    {
        int i = 1;
        foreach(Goal goal in goals)
        {
            goal.Display(i);
            i++;
        }

    }
    public void NewGoal()
    {
        Console.WriteLine("What kind of goal?");
        Console.WriteLine("1. One Time Goal");
        Console.WriteLine("2. Multiple Time Goal");
        Console.WriteLine("3.Eternal Goal");
        string type = Console.ReadLine();
        switch(type)
        {
            case "1":
                goals.Add(new SingleGoal());
                break;
            case "2":
                goals.Add(new SeveralGoal());
                break;
            case "3":
                goals.Add(new EternalGoal());
                break;
        }

    }
    public void SaveGoals()
    {
        using StreamWriter file = new(savefile, false);
        {
            file.WriteLine(points);
            foreach(Goal goal in goals)
            {
                file.WriteLine(goal.SaveData());
            }
        }
    }
}