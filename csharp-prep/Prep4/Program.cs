using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Diagnostics.Tracing;
class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        int high = 0;
        int low = 1000000;
        List<int> sorted = new List<int>();
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (num != 0)
        {
            Console.WriteLine("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
            numbers.Add(num);
            if (num > high)
            {
                high = num;
            }
            else if (num < low && num > 0)
            {
                low = num;
            }
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        sorted = numbers.OrderBy(p => p).ToList();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count()}");
        Console.WriteLine($"The highest number is: {high}");
        Console.WriteLine($"The lowest number is: {low}");
        Console.WriteLine("The sorted list is:");
        foreach (int numb in sorted)
        {
            Console.WriteLine(numb);
        }
    }
}