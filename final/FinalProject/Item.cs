using System;
using System.Collections.Generic;
using System.IO;

    public abstract class Item
    {
        protected string title;
        protected string genre;
        protected int agemin;
        public Item(string _title, string _genre, int _agemin)
        {
            title = _title;
            genre = _genre;
            agemin =_agemin;
        }

    }