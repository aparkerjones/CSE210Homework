using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        int choiceint;
        bool end = false;
        while (end == false)
        {
            int i = 1;
            List<string> menu = new List<string>{"Breathing Activity", "Reflection Activity", "Listing Activity"};
            Console.WriteLine("Welcome to the Mindfulness Program. Please enter your activity choice from the menu by its number or 0 to exit.");
            foreach(string option in menu)
            {
                Console.WriteLine($"{i}. {option}");
                i++;
            }
            choice = Console.ReadLine();
            choiceint = int.Parse(choice);
            switch(choiceint)
            {
                case 0:
                    end = true;
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                
            }
            
        }



    }
}