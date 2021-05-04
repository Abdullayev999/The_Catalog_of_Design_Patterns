using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace Proxy_Pattern
{
    class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Plot { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nYear: {Year}\n\n{Plot}";
        }
    }
    static class FakeMovieDatabase
    {
        static public List<Movie> Movies { get; }

        static FakeMovieDatabase()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Terminator",
                    Year = 1984,
                    Plot = "A seemingly indestructible Android is sent from 2029 to 1984 to " +
                    "assassinate a waitress, whose unborn son will lead humanity in a war against " +
                    "the machines, while a soldier from that war is sent to protect her at all cost"
                },
                new Movie
                {
                    Title = "Terminator 2",
                    Year = 1991,
                    Plot = "A cyborg, identical to the one who failed to kill Sarah Connor, " +
                    "must now protect her teenage son, John Connor, from a more advanced " +
                    "and powerful cyborg."
                },
                new Movie
                {
                    Title = "Terminator 3",
                    Year = 2003,
                    Plot = "A cybernetic warrior from a post-apocalyptic future travels back in " +
                    "time to protect a 25-year old drifter and his future wife from a most " +
                    "advanced robotic assassin and to ensure they both survive a nuclear attack."
                }
            };
        }
    }

    interface IMovieSearch
    {
        Movie Search(string title);
    }

    //Proxy
    class MovieSearchProxy : IMovieSearch
    {
        MovieSearchAPI search = null;

        public Movie Search(string title)
        {
            var movie = FakeMovieDatabase.Movies
                .Where(m => m.Title == title)
                .FirstOrDefault();

            if (movie == null)
            {
                if (search == null)
                    search = new MovieSearchAPI();

                movie = search.Search(title);
            }

            return movie;
        }
    }

    //Director
    class MovieSearchAPI : IMovieSearch
    {
        readonly string apiUrl = @"http://www.omdbapi.com/";
        readonly string apiKey = "2c9d65d5";

        public MovieSearchAPI()
        {
            Thread.Sleep(3000);
        }

        public Movie Search(string title)
        {
            Thread.Sleep(1000);
            var webClient = new WebClient();
            try
            {
                var result = webClient.DownloadString($"{apiUrl}?apikey={apiKey}&t={title}");
                dynamic data = JsonConvert.DeserializeObject(result);
                var movie = new Movie
                {
                    Title = data.Title,
                    Year = data.Year,
                    Plot = data.Plot
                };
                return movie;
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new Exception("Not found!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovieSearch movieSearch = new MovieSearchProxy();

            while (true)
            {
                Console.Clear();
                Console.Write("Enter the title: ");
                var title = Console.ReadLine();

                try
                {
                    var movie = movieSearch.Search(title);
                    Console.WriteLine(movie);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("\nPress ESC to exit or any key to continue...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
