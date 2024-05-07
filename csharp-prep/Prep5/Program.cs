using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcomeMessage();
      
        string uname = PromptUserName();
        int number = PromptUserNumber();
        int sqnumber = SquareNumber(number);
    
        DisplayResult(uname, sqnumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string uname = Console.ReadLine();
        return uname;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int sqnumber = number * number;
        return sqnumber;
    }
    static void DisplayResult(string uname, int sqnumber)
    {
        Console.WriteLine($"{uname}, the square of your number is {sqnumber}");
    }
    
}