using System;
using System.Collections.Generic;
using System.IO;

    public abstract class Item
    {
        protected string title;
        protected string genre;
        protected int agemin;
        public Item()
        {
            Console.WriteLine("What is the title?");
            title = Console.ReadLine();
            Console.WriteLine($"What is the genre of {title}?");
            genre = Console.ReadLine();
            Console.WriteLine($"What is the minimum recommended age for {title}?");
            string _agemin = Console.ReadLine();
            agemin = int.Parse(_agemin);
        }
        public abstract void Display(int count);
    }