using System;

class Breathing : Activity
{
    public Breathing()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < repetitions; i++)
        {
            Console.WriteLine("Inhale for 4 seconds");
            Spinner(4);
            Console.WriteLine("Hold for 7 seconds");
            Spinner(7);
            Console.WriteLine("Exhale for 8 seconds");
            Spinner(8);
        }
    }
}