using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    public class Film :IDisposable
    {
        public StringBuilder title { get; set; }
        public StringBuilder studio { get; set; }
        public Genre genre { get; set; }
        public StringBuilder duration { get; set; }
        public StringBuilder year { get; set; }

        public void Show()
        {
            Console.WriteLine("\nFilm information:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Film Studio: {studio}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Time: {duration} minutes");
            Console.WriteLine($"Year: {year}");
        }
        public void Dispose() 
        {
            title.Clear();
            studio.Clear();
            genre = 0;
            duration.Clear();
            year.Clear();
            Console.WriteLine("Object delete\n");
        }
        public Film(string Title, string Studio, string Genre, int Duration, int Year)
        {
            title = new StringBuilder(Title);
            studio = new StringBuilder(Studio);
            genre = (Genre)Enum.Parse(typeof(Genre), Genre);
            duration = new StringBuilder(Duration.ToString());
            year = new StringBuilder(Year.ToString());
            Console.WriteLine("Object create");
        }
    }
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Romance,
        SciFi,
        Thriller
    }
}