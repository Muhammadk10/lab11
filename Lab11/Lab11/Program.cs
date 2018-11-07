using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Movie
    {


        public Movie(string genre, string title)

        {
            Genre = genre;
            Title = title;

        }

        private string Genre { get; set; }
        private string Title { get; set; }

        public string _GetMovieTitle()
        {

            return Title;
        }

        public string _GetMovieGenre()
        {
            return Genre;
        }

       //creating a list 

        public class CreateMovielist
        {

            public static List<Movie> create()
            {
                var movies = new List<Movie>();

                movies.Add(new Movie("Animated", "Dragonballz"));
                movies.Add(new Movie("Scifi", "StarWars"));
                movies.Add(new Movie("Scifi", "Men in black"));
                movies.Add(new Movie("Comedy", "Step Brothers"));
                movies.Add(new Movie("Horror", "The Ring"));
                movies.Add(new Movie("Drama", "Logan"));
                movies.Add(new Movie("Drama", "Arrival"));
                movies.Add(new Movie("Comedy", "Repo Man"));
                movies.Add(new Movie("Animated", "Lion King"));
                movies.Add(new Movie("Animated", "Toy Story"));

                return movies;
            }
        }
    }


    class Program
    {
        private static string GetCorrectGenre()
        {


            string userInput = "";
            bool correctGenre = false;

            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are many movies in this list");
            Console.WriteLine("What category are you interested in?");
            Console.WriteLine("Please select from the following catagories : Scifi, Animated, Drama, or Horror");

            userInput = Console.ReadLine();

            userInput = userInput.ToLower();

            if (userInput == "animated" || userInput == "scifi" || userInput == "horrow" || userInput == "comedy")

            {
                correctGenre = true;
            }
            return userInput;


        }

        static void Main(string[] args)
        {
            string repeatProgram = "";
            

            string genreSelected = "";
            genreSelected = GetCorrectGenre();

            //  var movies = CreateMovielist.Create();
            do
            {


                Console.WriteLine("You picked" + "" + genreSelected);
                Console.WriteLine("Movies in this catagorie are the following):");
                Console.ReadLine();


                foreach (var movie in movies)
                {
                    if (movie.GetMusicGenre() == genreSelected)
                    {
                        Console.WriteLine(movie);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Would you like to run program again[y/n]");
                    repeatProgram = Console.ReadLine();


                    Console.ReadKey();
                }
                } while (repeatProgram == "y") ;
            }
        }
    } 

            