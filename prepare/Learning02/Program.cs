using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.Title = "Rookie";
        job1.employer = "Sports";
        job1.startYear = 2019;
        job1.endYear = 2020;

        Job job2 = new Job();
        job2.Title = "Player";
        job2.employer = "NBA";
        job2.startYear = 200;
        job2.endYear = 2023;

        Resume myResume = new Resume();
        myResume.name = "Steph Curry";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}