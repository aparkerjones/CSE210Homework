using System;

public class GetScripture
{
    private string correct = "no";
    private Scripture scripture = new Scripture();
    public Scripture GetVerses()
    {
        while (correct == "no")
        {
            Console.WriteLine("What is the scripture reference?");
            scripture.reference = Console.ReadLine();
            Console.WriteLine($"The scripture reference is {scripture.reference}. Is that correct?");
            correct = Console.ReadLine();
        }
        correct = "no";
        while (correct == "no")
        {
            Console.WriteLine("What is the text of the scripture?");
            scripture.verses = Console.ReadLine();
            
        }
        return scripture;
    }
}