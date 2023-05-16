using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    public class Performance : IDisposable
    {
        public StringBuilder title { get; set; }
        public StringBuilder theatre { get; set; }
        public TheaterGenre genre { get; set; }
        public StringBuilder duration { get; set; }
        public List<StringBuilder> actors { get; set; }

        public void Show()
        {
            Console.WriteLine("\nPerformance information:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Theatre: {theatre}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Duration: {duration} minutes");
            Console.WriteLine("Actors:");
            foreach (var actor in actors)
            {
                Console.WriteLine(actor);
            }
        }
        public void Dispose()
        {
            title.Clear();
            theatre.Clear();
            genre = 0;
            duration.Clear();
            actors.Clear();
            Console.WriteLine("Object delete\n");
        }
        public Performance(string Title, string Theatre, string Genre, int Duration, List<string> Actor)
        {
            title = new StringBuilder(Title);
            theatre = new StringBuilder(Theatre);
            genre = (TheaterGenre)Enum.Parse(typeof(TheaterGenre), Genre);
            duration = new StringBuilder(Duration.ToString());
            actors = new List<StringBuilder>();
            foreach (string actor in Actor)
            {
                actors.Add(new StringBuilder(actor));
            }
            Console.WriteLine("Object create");
        }
    }
    public enum TheaterGenre
    {
        Drama,
        Comedy,
        Tragedy,
        Musical,
        Farce,
        Historical,
        Experimental
    }
}