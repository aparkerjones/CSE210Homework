using System;
using System.Text.RegularExpressions;
public class Verse
{
    private List<Word> verse = new List<Word>();
    private string delimiters = @"(?<=\s)|(?=[\s;,!?.])";
    public Verse(string wholeverse)
    {
        PopWordList(wholeverse);   
    }
        private void PopWordList(string _verse) //this makes the list of word classes for all the words in the verse
    {
        string[] splitVerse = Regex.Split(_verse, delimiters); //this takes the verse and splits it acording to the delimiterChars' it splits all words, punctuation, and spaces and turns it into a word class
        for (int i = 0; i < splitVerse.Length; i++) //iterate through the word list
        {
            Word nextWord = new Word(splitVerse[i], false); // make a word class populated with the current word
            verse.Add(nextWord);// put that word into the list of all words
        } 
    }
    public void PrintVerse()
    {
        for (int i = 0;i < verse.Count(); i++)
        {
            verse[i].DisplayWord();
        } 
        Console.WriteLine();
    }
    public List<Word> GetAllWords()
    {
        return verse;
    }


}