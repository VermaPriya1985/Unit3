using System;
using System.Collections.Generic;
// using ComITLibrary;
using PasswordGenerator;
namespace Unit3examples
{
    class Program
    {
        static void Main(string[] args)
        {   

            var somemoview = new Movie("ABC","ABC Director",1990);

            try
            {
            somemoview.AddRating(1);
            somemoview.AddRating(4);
            somemoview.AddRating(5);
            somemoview.AddRating(4);

            }
            
            catch (System.Exception)
            {
                
                throw;
            }

            // double avg = somemoview.GetAverageRating();
            double avg = somemoview.AverageRating;
            
            Console.WriteLine("Rating is: " + avg);
            Movie.Greeting();

            int f =4;
        

            var pwd = new Password();
            string generatepwd = pwd.Next();
            Console.WriteLine("The Password is: " + generatepwd);

            // Movie mymovie = new Movie("Jurassic Park","ABC",1993);
           
            /* Movie mymovie = new Movie();
            mymovie.Title = "ABCD";
            mymovie.Director = "XYZ";
            mymovie.Year = 1993;
            */
            
            //  2nd method to declare movie object
            /* Movie mymovie = new Movie(){
                Title = "ABCD",
                Director = "XYZ",
                Year = 1993
            };

            Console.WriteLine(mymovie.Title);
            mymovie.PrintDetails();
            */

            //  mymovie.GetMovieTitle();

            //  mymovie.SetTitle("New Movie Title");
            
            //  mymovie.PrintDetails();

            var thedate = new DateTime(2010,6,29);
            var firstpost = new SocialMediaPost("helloworld",thedate,5);
            
            var secondpost = new SocialMediaPost();
            secondpost.PrintDetails();

            // Customer c1 = new Customer();
            // c1.Id = 1;
            // c1.FirstName = "Priya";
            // c1.LastName = "verma";
            // c1.PrintGreeting();

            // 2nd method
            Customer c1 = new Customer()
            {
            FirstName = "Priya",
            LastName = "verma",
            Dob = new DateTime(2000,12,20)
            };
            c1.PrintGreeting();
            // We want to use c1.Age instead of GetAge becaise Age is property of customer
            // int age = c1.GetAge();
            // Console.Write(age);            
            Console.WriteLine(c1.Age);
            c1.SendMail("zz","z");

            LibraryPatron lib = new LibraryPatron(1);
            
        }
    }

    // Animal
   /* class Animal
    {
        // Animal Properties
        public long Id{get;set;}
        public string Name{get;set;}
        public string Type{get;set;}
        public string Breed{get;set;}
        public string Location{get;set;}
        public double Latitude{get;set;}
        public double Longitude{get;set;}
        public bool IsAdopted{get;set;}

        // Adoption Properties
        public string AdoptionName{get;set;}
        public float Age{get;set;}
        public string AdoptionMob{get;set;}
        public string Address{get;set;}
        
        // Methods

        // Add New Animal
        public void AddAnimal()
        {
            // Code to add new Animal
            Console.WriteLine("New Animal added successfully");
        }
        // Update Animal
        public void UpdateAnimal()
        {
            // Code to edit Animal
            Console.WriteLine("Animal updated successfully");
        }
        // Delete Animal
        public void DeleteAnimal()
        {
            // Code to delete Animal
            Console.WriteLine("Animal deleted successfully");
        }
        // Get All Animals
        public void GetAllAnimals()
        {
            Console.WriteLine($"Name of Animal is: {Name}\n");
            Console.WriteLine($"Type of Animal is: {Type}\n");
            Console.WriteLine($"Breed of Animal is: {Breed}\n");
            Console.WriteLine($"Location of Animal is: {Location}\n");
            Console.WriteLine($"Latitude of Animal is: {Latitude}\n");
            Console.WriteLine($"Longitude of Animal is: {Longitude}\n");
        }
        // Add New Adoption 
        public void AddAdoption()
        {
            // Code to add new Adoption
            Console.WriteLine("New Adoption added successfully");
        }
        // Update Adoption 
        public void UpdateAdoption()
        {
            // Code to add new Adoption
            Console.WriteLine("Adoption updated successfully");
        }
        // Delete Adoption 
        public void DeleteAdoption()
        {
            // Code to add new Adoption
            Console.WriteLine("Adoption deleted successfully");
        }
        // Get Weather Information based on latitude and longitude
        public string GetWeather(double latitude, double longitude)
        {
           // Code to get weather information
           string info = "Rain";
           return info; 
           // Console.WriteLine($"Weather is: {str}\n");
        }
        // Animal is adopted or not, either Yes or No
        public void IsAnimalAdopted()
        {
           Console.WriteLine($"Is Animal adopted: {IsAdopted}\n");
        }
        // Animal Allocated to Adoption 
        public void BindAnimalToAdopt()
        {
           Console.WriteLine($"This Animal adopted to {AdoptionName}\n");
        }
        // Validate Adoption Age, should be greater than 18  
        public void ValidateAdoptionAge()
        {
           // Code to validate adoption age
           Console.WriteLine("Age should be greater than 18");
        }
        // Validate Mobile No, should be unique
        public void ValidateMobileNo()
        {
           // Code to validate adoption mobile
           Console.WriteLine("Mobile Number should be unique");
        }
        
    }
*/
// Library
/* public class LibraryPatron 
{
        // Constructor
        public LibraryPatron(int patronId) {
            PatronId = patronId;
            FinesOwing = 0;
            BooksCheckedOut = 0;
        }

        // Properties (Data)
        public int PatronId {get; set;}
        public double FinesOwing {get; set;}
        public int BooksCheckedOut {get;set;}


        // Methods
        public void CheckoutBook(string bookName) 
        {
            if (BooksCheckedOut < 5) {
                BooksCheckedOut++;
                Console.WriteLine($"Patron {PatronId} has checked out {bookName}\n");
            } else {
                Console.WriteLine($"Patron {PatronId} cannot check out more than 5 books\n");
            }    
        }

        // Note: Since this is a simplified example, we are not specifying any particular book being returned
        public void ReturnBook() {
            if (BooksCheckedOut > 0) {
                BooksCheckedOut--;
            } else {
                Console.WriteLine("Patron has no books to return.\n");
            }
        }

        public void AddOverdueCharge() {
            // Note: Assume there is a set fine amount of 1.60 that gets incurred
            FinesOwing += 1.60;
            Console.WriteLine($"Patron {PatronId} has incurred a fine\n");
        }

        public void PayFine(double amountPaid) {
            if (amountPaid >= FinesOwing) {
                double change = amountPaid - FinesOwing;
                FinesOwing = 0;
                // Note: ToString("N2") allows us to display a string with 2 numbers after the decimal
                Console.WriteLine($"Fines are all paid. Your change is {change.ToString("N2")}\n");
            } else {
                FinesOwing -= amountPaid;
                Console.WriteLine($"${amountPaid.ToString("N2")} has been paid towards the total fine\n");
            }
        }

        public void PrintDetails() {
            Console.WriteLine($"\n--- Patron {PatronId} ---");
            Console.WriteLine($"Books out: {BooksCheckedOut}/5");
            Console.WriteLine($"Fees: ${FinesOwing.ToString("N2")}");
            Console.WriteLine("-----------------\n");
         }
    } */ 
}
