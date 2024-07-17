using System;

class Activity
{
    protected int repetitions;
    protected int duration;
    protected string  _duration;
    protected List<string> prompts = new List<string>();
    public Activity()
    {
        Console.WriteLine("How many times do you want to repeat the activity?");
        string _repetitions = Console.ReadLine();
        repetitions = int.Parse(_repetitions);
    }
    public void Spinner(int time)
    {

        // Array of characters to create a spinner effect
        char[] spinner = new char[] { '|', '/', '-', '\\' };

        // Calculate the interval for each symbol (in milliseconds)
        int interval = 250;


        for (int j = 0; j < time; j++)
        {
            foreach (char symbol in spinner)
            {
                // Display the spinner symbol
                Console.Write(symbol);

                // Wait for the interval duration
                Thread.Sleep(interval);

                // Move the cursor back to overwrite the spinner symbol
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine(time-j);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        // Clear the spinner symbol after completion
        Console.Write(' ');
    }
}