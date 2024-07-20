using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        bool end = false;
        Console.WriteLine("Welcome to your home library management system.");
        while (end == false)
        {
            List<string> options = ["Add New Goal", "Mark Goal Complete", "Display All Goals", "Close Tracker"];
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Menu:");
            int i = 1;
            foreach (string option in options)
            {
                Console.WriteLine($"{i}. {option}");
                i++;
            }
            Console.WriteLine("Please enter the number of your choice from the menu");
            string choice = Console.ReadLine();
            int num = int.Parse(choice);
            switch (num)
            {
                case 1:
                    tracker.NewGoal();
                    break;
                case 2:
                    tracker.CompleteGoal();
                    break;
                case 3:
                    tracker.DisplayGoals();
                    break;
                case 4:
                    tracker.SaveGoals();
                    end = true;
                    break;
            }
        }
    }
}