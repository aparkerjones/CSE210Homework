using System;

class Program
{
    static void Main(string[] args)
    {
        string playagain = "yes";
        while (playagain == "yes")
        {
        string loop = "yes";
        Console.WriteLine("Guess the number!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int count = 0;
        while (loop == "yes")
        {
        count += 1;
        Console.WriteLine("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        if (number == guess)
        {
            Console.WriteLine("You guessed it!");
            loop = "no";
            Console.WriteLine($"It took you {count} guesses!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        }
        Console.WriteLine("Do you want to play again (yes or no)?");
        playagain = Console.ReadLine();
        }
}