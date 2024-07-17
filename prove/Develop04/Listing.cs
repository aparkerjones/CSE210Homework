using System;

class Listing : Activity
{
    int prompt;
    public Listing()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        prompts = new List<string>{"some of your favorite things", "some of your talents", "some of your strengths", "some ways you have improved recently", "people you care about", "some things have brought you joy recently"};
        Console.WriteLine("How long do you want to have to list things?");
        _duration = Console.ReadLine();
        duration = int.Parse(_duration);
        for (int i = 0; i < repetitions; i++)
        {
            Random random = new Random();
            prompt = random.Next(1, prompts.Count);
            Console.WriteLine("Ready?");
            Thread.Sleep(500);
            Console.WriteLine("Set?");
            Thread.Sleep(500);
            Console.WriteLine($"Think of {prompts[prompt]}");
            Spinner(duration);
        }
    }

}