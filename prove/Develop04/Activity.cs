using System;
class Activity
{
    protected int repetitions;
    protected int duration;
    protected string  _duration;
    protected List<string> prompts = new List<string>();
    public Activity()
    {
        Console.WriteLine("How many times do you want to repeat the activity?");
        string _repetitions = Console.ReadLine();
        repetitions = int.Parse(_repetitions);
    }
    public void Spinner(int time)
    {
        
        string[] animationList = 
            {"╔══╗\n║  ║\n╚══╝",
            "╔═ ╗\n║  ║\n╚══╝",
            "╔═  \n║  ║\n╚══╝",
            "╔═  \n║   \n╚══╝",
            "╔═  \n║  \n╚══ ",
            "╔═  \n║  \n╚═  ",
            "╔═  \n║   \n╚   ",
            "╔═  \n║   \n    ",
            "╔═ \n    \n    ",
            " ═ \n    \n    ",
            "   \n   \n    ",
            "  ═ \n    \n    ",
            "  ═╗\n    \n    ",
            "  ═╗\n   ║\n    ",
            "  ═╗\n   ║\n   ╝",
            "  ═╗\n   ║\n  ═╝",
            "  ═╗\n   ║\n ══╝",
            "  ═╗\n   ║\n╚══╝",
            "  ═╗\n║  ║\n╚══╝",
            "╔ ═╗\n║  ║\n╚══╝",
            "╔══╗\n║  ║\n╚══╝"}; 
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {   
            Console.CursorVisible = false;
            TimeSpan timeWait = futureTime-currentTime;
            for (int i = 0; i < animationList.Length; i++)
               {

                Thread.Sleep(50);
                Console.CursorVisible = false;
                Console.Write(animationList[i]);
                Console.CursorVisible = false;
                Console.SetCursorPosition(1,Console.CursorTop-1);
                Console.CursorVisible = false;
                Console.Write(timeWait.Seconds);
                Console.CursorVisible = false;
                Console.SetCursorPosition(0,Console.CursorTop-1);
                Console.CursorVisible = false;
                currentTime = DateTime.Now;
               }
        }
        
        Console.CursorVisible = true;
        Console.Clear();
    }
}