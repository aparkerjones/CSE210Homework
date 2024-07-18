using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel.Design;
string savefile = "homeentertainmentshelf.txt";
Shelf shelf = new(savefile);
bool end = false;
Console.WriteLine("Welcome to your home library management system.");
while (end == false)
{
    List<string> options = ["Add New Item", "Delete Item", "Display Library", "Save to File", "Discard Changes","Pick something random to do", "Exit"];
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("Menu:");
    int i = 1;
    foreach (string option in options)
    {
        Console.WriteLine($"{i}. {option}");
        i++;
    }
    Console.WriteLine("Please enter the number of your choice from the menu");
    string choice = Console.ReadLine();
    int num = int.Parse(choice);
    switch (num)
    {
        case 1:
            shelf.NewItem();
            break;
        case 2:
            shelf.RemoveItem();
            break;
        case 3:
            shelf.DisplayShelf();
            break;
        case 4:
            shelf.SaveShelf(savefile);
            break;
        case 5:
            shelf = new Shelf(savefile);
            break;
        case 6:
            shelf.Bored();
            break;
        case 7:
            end = true;
            break;
    }
}
