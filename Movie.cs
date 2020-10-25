using System;
using System.Collections.Generic;
namespace Unit3examples
{
    public class Movie 
    {
        // constructor initialize all of data members
        public Movie(string title, string director, int year) 
        {
            // list of ratings will be null, if constructor is not created
            // title, director etc is empty string 
            Title = title;
            Director=director;
            Year=year;
            // initialize list as empty list else get NULL exception
            _ratings=new List<int>();
            Id=Guid.NewGuid();
        } 

        public Guid Id{get; private set;}
        public string Title{get;set;}
        public string Director{get;set;}
        public int Year{get;set;}

        // Collection of Ratings, make it private field with lower case
        // public List<int> Ratings {get;private set}
        private List<int> _ratings;

        // Code to rate movie
        /* public void MovieRate()
        {
            // Code to track movie rate
        } */

         // Property approach to average rating
        public double AverageRating { 
            get {
                int sum = 0;

                for (int i = 0; i < _ratings.Count; i++) {
                    sum += _ratings[i];
                }

                double average = (double)sum / (double)_ratings.Count;
                return Math.Round(average, 1);
            }
        }

        public void AddRating(int ratingToAdd)
        {
            if(ratingToAdd>=1 && ratingToAdd<=5)
            {
            Console.WriteLine($"Add Rating: {ratingToAdd}");
            _ratings.Add(ratingToAdd);
            }
            else
            {
                throw new Exception("Invalid Rating");
                // Console.WriteLine("Invalid Rating");
            }
        }

        public double GetAverageRating()
        {
                int sum =0;
                for(int i=0;i<_ratings.Count;i++)
                {
                    sum += _ratings[i];
                }
                double average = (double)sum / (double)_ratings.Count;
                return Math.Round(average, 1);
                // return average;

        }

        public void PrintDetails()
        {

           Console.WriteLine(Title);
           Console.WriteLine(Director);
           Console.WriteLine(Year);
          
        }

        // Static method, it does not associated with any one particular movie
     
        public static void Greeting()
        {
            Console.WriteLine("Hello World");
            // _ratings.Add(4);
        } 
    }
}

    // class Movie
    // {
    //     static void Run(string[] args)
    //     {   
    //         // Movie mymovie = new Movie("Jurassic Park","ABC",1993);
           
    //         /* Movie mymovie = new Movie();
    //         mymovie.Title = "ABCD";
    //         mymovie.Director = "XYZ";
    //         mymovie.Year = 1993;
    //         */

    //         //  2nd method to declare movie object
    //         Movie mymovie = new Movie(){
    //             Title = "ABCD",
    //             Director = "XYZ",
    //             Year = 1993
    //         };

    //         Console.WriteLine(mymovie.Title);
    //         mymovie.PrintDetails();

    //         //  mymovie.GetMovieTitle();

    //         //  mymovie.SetTitle("New Movie Title");
            
    //         //  mymovie.PrintDetails();

            
    //         // why we use constructor instead of putting values in data members like below:
    //         /* Movie mymovie = new Movie();
    //         mymovie.title = "Jurassic park";
    //         mymovie.director = "AbC";
    //         mymovie.year = 1993; */
            
            
    //         // Console.WriteLine(mymovie.title);
    //         // Console.WriteLine(mymovie.director);
    //         // Console.WriteLine(mymovie.year);
    //         // var toystory = new Movie();
    //         // Console.WriteLine("Hello World!");
    //     }
    // }

    // // Social Media 



// we can have multiple constructor

    // we can have multiple constructor


    // Create class, class is template or blue print 
        // Constructor, allows to build movie, assign values to different data members like title 
        // its very similar to function. 
        //Constructor is a method allows to set data members like title, year
    //    public Movie(string theTitleArgument, string theDirectorArgument, int theYearArgument)
    //    {
    //     title = theTitleArgument;
    //     director = theDirectorArgument;
    //     year=theYearArgument;
    //     }
    
    //   Data
    // string title;
    // string director;
    // int year;

    // Methods to work with data: title, director, year, remain it public to access
    // outside of the movie class 
    
    // In C#, Instead of getmovietitle and settitle, we have 2 properties set and get
    // you can define your own get and set, so we dnt need define above data members

    // public string Title{get; private set} 
    
        /* public string GetMovieTitle()
    {
        return title;
    }

    public void SetTitle(string newtitle)
    {   
        title = newtitle;
    } */


