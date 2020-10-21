using System;
using System.Collections.Generic;
namespace Unit3examples 
{
 //    class Customer
 //   {
        //static void Main(string[] args)
        //{   

            // Customer c1 = new Customer();
            // c1.Id = 1;
            // c1.FirstName = "Priya";
            // c1.LastName = "verma";
            // c1.PrintGreeting();
            
            // 2nd method
            // Customer c1 = new Customer()
            // {
            // FirstName = "Priya",
            // LastName = "verma",
            // Dob = new DateTime(2000,12,20)
            // };
            // c1.PrintGreeting();
            // We want to use c1.Age instead of GetAge becaise Age is property of customer
            // int age = c1.GetAge();
            // Console.Write(age);            
//            Console.WriteLine(c1.Age);
 //           c1.SendMail("zz","z");
//        }
   // }

    // Social Media 

    class Customer
{
    // public Customer(string firstname, string lastname)
    // {
      // Can use constructor here to validate firstname,lastname nt empty

    // }
    // first name, last name, id, date of birth, email address
    public string FirstName{get;set;}
    public string LastName{get;set;}
     public string FullName 
     {
            get 
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
     }

    public long Id{get;set;}
    public DateTime Dob{get;set;}
    public string Email{get;set;}
    public int Age 
    { 
    get
    {
         DateTime currentDate = DateTime.Now;
         int age = currentDate.Year - Dob.Year;
           if (currentDate.DayOfYear < Dob.DayOfYear) {
                    age--;
                }

        return age;
    }
    }
    // print greeting
    public void PrintGreeting()
    {
        Console.WriteLine($"Hello {FirstName} {LastName}!");
        // string str = "welcome to: " + name;
        // return  str;
      
    }      
    // send mail
    public void SendMail(string subject, string bodyText)
    {
    //      // Code to send email
           Console.WriteLine($"Email was sent to {Email}");
    }
    // get age
    /*public int GetAge()
    {
         DateTime currentDate = DateTime.Now;
         int age = currentDate.Year - Dob.Year;
           if (currentDate.DayOfYear < Dob.DayOfYear) {
                    age--;
                }

         return age;
    }*/
    
 }
}
