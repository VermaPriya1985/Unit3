using System;
using System.Collections.Generic;
namespace Unit3examples
{
    // class SocialMediaPost
    // {
    //     static void Main(string[] args)
    //     {   
            //int year = 2020;
            //string myname = "priya";
            //List<int> mylist = new List<int>();
            // Datetime is constructor, year, month are members of DateTime class
            // DateTime somedate = new DateTime(2010,2,2);
            
         //   var myotherlist = new List<float>();
    
            // var thedate = new DateTime(2010,6,29);
            // var firstpost = new SocialMediaPost("helloworld",thedate,5);


            // firstpost.PrintDetails();
            
            // var secondpost = new SocialMediaPost();
            // secondpost.PrintDetails();

            // var thirdpost = new SocialMediaPost("this is my another post");

            // var secondpost = new SocialMediaPost();

            // firstpost.AddLike();
            // firstpost.nooflikes = -50; 

            // for(int i=0;i<100;i++)
            // {
                //firstpost.AddLike();
            // }

            //firstpost.PrintDetails();
            
            // why we use constructor instead of putting values in data members like below:
            /* Movie mymovie = new Movie();
            mymovie.title = "Jurassic park";
            mymovie.director = "AbC";
            mymovie.year = 1993; */
            
            
            // Console.WriteLine(mymovie.title);
            // Console.WriteLine(mymovie.director);
            // Console.WriteLine(mymovie.year);
            // var toystory = new Movie();
            // Console.WriteLine("Hello World!");
       // }
  //  }

    // Social Media 

 

// we can have multiple constructor

    public class SocialMediaPost
    {
        // Constructor, we can have multiple constructor
        // Constructor is the way to create objects of socialmediapost class

        public SocialMediaPost()
        {

            text = "This is a sample post";
            timeofpost= DateTime.Now;
            nooflikes = 1;
        }

        public SocialMediaPost(string textargument)
        {
                text=textargument;
                timeofpost= DateTime.Now;
                nooflikes = 0;

        }

        public SocialMediaPost(string textargument, DateTime timeofpostargument,
        int nooflikesargument)
        {
                text=textargument;
                timeofpost=timeofpostargument;
                nooflikes=nooflikesargument;
        }
        string text;
        DateTime timeofpost;
        int nooflikes;   
        // Print Details Method
        public void PrintDetails()
        {

            // Console.WriteLine(text);
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Time of post: {timeofpost}");
            Console.WriteLine($"No of likes: {nooflikes}\n");
        }
        // Create Method that increase no of likes 
        public void AddLike()
        {
            Console.WriteLine("somebody likes this post\n");
            nooflikes++;
        }
    }

    // we can have multiple constructor


    // Create class, class is template or blue print 
  
    // }
}
