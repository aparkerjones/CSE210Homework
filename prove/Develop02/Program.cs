using System;

public class Program
{
    public static void Main()
    {
        Journal _journal = new Journal();
        List<Entry> entries = new List<Entry>();
        int repeat = 1;
        int choice;
        
        while (repeat == 1)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("What would you like to do?");
            List<string> menu = [". Quit", ". Display Last Entry", ". Display All Entries", ". Save New Entry", ". Create New Journal"];
            for (int i = 1; i <= menu.Count(); i++)
            {
                Console.WriteLine($"{i-1}{menu[i-1]}");
            }
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 0:
                    repeat = 0;
                    break;
                case 1:
                    _journal.DisplayLast(entries);
                    break;
                case 2:
                    _journal.DisplayAll(entries);
                    break;
                case 3:
                    Entry.NewEntry(entries);
                    break;
                case 4:
                    
                    break;
            }
        }


    }
    
}