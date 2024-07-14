using System;
using System.Collections.Generic;
using System.IO;

public class Movie: Item
{
    int time;

    public Movie(string _title, string _genre, int _agemin, int _time) : base(_title, _genre, _agemin)
    {
        time = _time;
    }
    public List<Movie> NewItem(List<Movie> movies)
    {
        Console.WriteLine("What is the movie's title?");
        string title = Console.ReadLine();
        Console.WriteLine($"What is the genre of {title}?");
        string genre = Console.ReadLine();
        Console.WriteLine($"What is the minimum recommended age for {title}?");
        string age = Console.ReadLine();
        Console.WriteLine($"What is the running time of {title}?(in minutes)");
        string time = Console.ReadLine();
        int runtime = int.Parse(time);
        Movie movie = new Movie(title, genre, agemin, runtime);
        movies.Add(movie);
        return movies;
    }

    public void DisplayMovies(List<Movie> movies)
    {
        Console.WriteLine("Your books are:");
        foreach(Movie movie in movies)
        {
            Console.WriteLine($"Title:{movie.title} Genre: {movie.genre} Age Minimum: {movie.agemin} Running Time(minutes): {movie.time}");
        }
    }
    public List<Movie> LoadLibrary(string savefile, List<Movie> movies)
    {
        return movies;
    }
    public void SaveLibrary(List<Item> movies, string savefile)
    {
        
    }
        public List<Movie> RemoveItem(List<Movie> movies)
    {
        return movies;
    }
}