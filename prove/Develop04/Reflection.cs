using System;

class Reflection : Activity
{
    List<string> questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel afterwards?", "What made this different from other situations?", "What was your favorite part of this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself?"};
    int prompt;
    public Reflection()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        prompts = new List<string>{"Think of a time you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time you helped someone in need.", "Think of a time you did something truly selfless."};
        Console.WriteLine(" How long do you need to think of an experience?");
        _duration = Console.ReadLine();
        duration = int.Parse(_duration);
        Random random = new Random();
        prompt = random.Next(1, prompts.Count);
        _duration = Console.ReadLine();
        duration = int.Parse(_duration);
        for (int i = 0; i < repetitions; i++)
        {
            Console.WriteLine("Ready?");
            Thread.Sleep(500);
            Console.WriteLine("Set?");
            Thread.Sleep(500);
            Console.WriteLine($"Think of {prompts[prompt]}");
            Spinner(duration);
            foreach(string words in questions)
            {
                Console.WriteLine(words);
                Spinner(duration);
            }
        }
    }

}