using System;
namespace Unit3examples
{
    // Animal
    class Animal
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
}
