using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace Flyweight_Pattern
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

    interface ICache<TKey, TValue>
    {
        TValue GetValue(TKey key);
        void AddValue(TKey key, TValue value);
    }

    // FlyWeight
    class MovieCache : ICache<string, Movie>
    {
        Dictionary<string, Movie> movies = new Dictionary<string, Movie>();

        public Movie GetValue(string key)
        {
            if (movies.ContainsKey(key))
            {
                return movies[key];
            }
            return null;
        }

        public void AddValue(string key, Movie value)
        {
            movies.Add(key, value);
        }
    }

    class MovieSearchAPI
    {
        readonly string apiUrl = @"http://www.omdbapi.com/";
        readonly string apiKey = "2c9d65d5";

        ICache<string, Movie> cache = new MovieCache();

        public Movie Search(string title)
        {
            var movie = cache.GetValue(title);
            if (movie == null)
            {
                Console.WriteLine("Reading data from API...");

                var webClient = new WebClient();
                try
                {
                    var result = webClient.DownloadString($"{apiUrl}?apikey={apiKey}&t={title}");
                    dynamic data = JsonConvert.DeserializeObject(result);
                    movie = new Movie
                    {
                        Title = data.Title,
                        Year = data.Year,
                        Plot = data.Plot
                    };
                    cache.AddValue(movie.Title, movie);
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
            else
            {
                Console.WriteLine("Reading data from cache...");
            }
            return movie;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var search = new MovieSearchAPI();

            var menuItems = new List<string>
            {
                "Inception",
                "Interstellar",
                "Dunkirk"
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the movie: ");
                int index = 1;
                foreach (var item in menuItems)
                {
                    Console.WriteLine($"{index++}) {item}");
                }

                Int32.TryParse(Console.ReadLine(), out int number);
                try
                {
                    var movie = search.Search(menuItems[number - 1]);
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
