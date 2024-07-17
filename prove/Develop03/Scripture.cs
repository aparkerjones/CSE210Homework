using System.Text.RegularExpressions;
public class Scripture 
{     
    private List<Verse> allVerses = new List<Verse>(); //this wholds the list of multiple verses
    private List<Word> allShown = new List<Word>(); //This holds the list of all Words that are not punctuation and that are not dashed
    private string reference; //This is just where the reference is stored
    public int difficulty = 5; //This sets how many words are hidden at a time.
    private int totalIterations;
    private int looped = 0; //This keeps track of how many times you have looped
    private string action; //This is just here to see if the user typed "quit"

    public Scripture(string _reference,string text) //The constructor takes in the reffeance and the text
    {
        reference = _reference;   //It puts the refferance in the referance variable 
        SplitVerse(text); //It runs the Split Verse method. Before I had the whole text stored as variable and then the method was run but I realized I don't need all that text. So I never store it. I split it into verse and drop it.
        MakeTotalList(); //This takes every word from every verse that is a word (not a punctiaon or space) and stores it in a list that will have the hidden variables hidden from it.
        totalIterations = (allShown.Count / difficulty)+2; //This just says how many times to itterate. It spits back the how many times the program can completely hide the difficulty's amount of text.
    }
    private void SplitVerse(string wholeText) //splits all the text based on if it sees a number
    {
        string[] verse = Regex.Split(wholeText,@"(?<=\D)(?=\d+)"); //(?<=\D): () means keep what you find, ?<= means look behind to, \D means check that it wasn't an integer. (?=\d+) it means the same thing except ?= means look ehead and /d+ means check that the thing ahead is a number (then don't split here) the + means it can be any number from 1 to anything.
        foreach (string i in verse) // all the text has been split before the numbers
        {
            Verse stuff = new Verse(i); //make a new verse instance
            allVerses.Add(stuff); //add that verse to the list of verse
            
            
        }
    }
    private void MakeTotalList() //this is making the list of words to hide
    {
        
        foreach (Verse verse in allVerses)
        {
            foreach (Word word in verse.GetAllWords())
            {
                
                if (word.checkwords() == true)
                {
                    allShown.Add(word);
                }
            }
        }
    }
    public void RunScripture()
    {
        do
        {
            Console.Clear(); //clearsconsole
            Console.WriteLine(reference); //prints the reference first and formost
            foreach (Verse verse in allVerses) //for each verse run it's print function
            {
                verse.PrintVerse();
            }
            action = Console.ReadLine().ToLower(); //stop and wait for the quit or really anything so you can see stuff
            HideNextBatch();//run the hide function to hide the next few words
            looped++; //add to the loop amount
            
            
        } while(looped < totalIterations && action != "quit"); // if the acumulated amount of loops is less than the amount I said it should loop and nobody typed quit keep going. If either become false the loop ends
    }
      private void HideNextBatch()//heres how we decide what to hide
    {
        Random random = new Random();
        for (int i = 0; i < 5; i++)// this will hide one word for the amount the difficulty sets
        {
            if (allShown.Count() != 0) //make sure there is still stuff to hide
            {
                int toHide = random.Next(0,allShown.Count); // get a random integer between 0 and how ever long the avilble words list is.
                allShown[toHide].dashword();// set that word to hidden
                allShown.RemoveAt(toHide); // and remove that word from the list so it will give a true reading next time
            }
            else
            {
                break; //if the available list is 0 don't run this function anymore
            }

        }
    }
}