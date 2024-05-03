using System;

class Program
{
    static void Main()
    {
        float percentage;
        string grade;
        string score;
        string modifier;
        Console.WriteLine("What is the grade percentage? ");
        score = Console.ReadLine();
        percentage = float.Parse(score);
        if (percentage % 10 >= 7)
        {
            modifier = "+";
        }
        else if (percentage % 10 < 3)
        {
            modifier = "-";
        }
        else
        {
            modifier = " ";
        }
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if ((grade == "A" && modifier == "+")|| (grade == "F" && modifier != " "))
        {
            Console.WriteLine($"The grade is {grade}.");
        }
        else
        {
            Console.WriteLine($"The grade is {grade}{modifier}.");
        }
    }
}