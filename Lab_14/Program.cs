using System.Text;

namespace Lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Enter task (1 - 2): ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("\nEnter title of film: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter film studio of film: ");
                        string filmstudio = Console.ReadLine();
                        Console.Write("Enter genre of film (Action, Comedy, Drama, Fantasy, Horror, Romance, SciFi, Thriller): ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter duration of film: ");
                        int duration = int.Parse(Console.ReadLine());
                        Console.Write("Enter year of film: ");
                        int year = int.Parse(Console.ReadLine());

                        using (Film film = new Film(name, filmstudio, genre, duration, year))
                        {
                            film.Show();
                        }

                        break;
                    case 2:
                        Console.Write("\nEnter title of performance: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter name of theatre of performance: ");
                        string theatre = Console.ReadLine();
                        Console.Write("Enter genre of performance (Drama, Comedy, Tragedy, Musical, Farce, Historical, Experimental): ");
                        string theatregenre = Console.ReadLine();
                        Console.Write("Enter duration of performance: ");
                        int theatreduration = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of actors: ");
                        int numberActors = int.Parse(Console.ReadLine());

                        List<string> actors = new List<string>();
                        for (int i = 0; i < numberActors; i++)
                        {
                            Console.Write($"Enter name of actor {i + 1}: ");
                            string actor = Console.ReadLine();
                            actors.Add(actor);
                        }

                        using (Performance performance = new Performance(title, theatre, theatregenre, theatreduration, actors))
                        {
                            performance.Show();
                        }

                        break;
                    default: 
                        Console.WriteLine("Error!"); 
                        break;
                }
            }
        }
    }
}