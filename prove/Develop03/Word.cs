using System;

public class Word
{
    private string word;
    private bool dashed;
    bool isWord;
    private List<char> delimiterChars = ['(', ')', ' ', ';', ',', '!', '?', '.', ']', '[', ':'];
    
    public Word(string _word, bool _dashed)
    {
        word = _word;
        dashed = _dashed;
    }
    public void DisplayWord()
    {
        
        if (dashed == false)
            Console.Write(word);
        else
            foreach (char c in word)
            Console.Write("_");
    }
    public bool checkwords()
    {
        if (word.All(c => delimiterChars.Contains(c)) | int.TryParse(word, out int number))
        {
            isWord = false;
        }
        else
        {
            isWord = true;
        }

        return isWord;
    }
        public bool dashword()
    {   
        dashed = true;
        return dashed;
    }
    
}