using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment today = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(today.GetSummary());

        MathAssignment tomorrow = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(tomorrow.GetSummary());
        Console.WriteLine(tomorrow.GetHomeworkList());

        WritingAssignment dayafter = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(dayafter.GetSummary());
        Console.WriteLine(dayafter.GetWritingInformation());
    }
}