using System;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void SetCarDetails(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    
}

class Program
{
    static void Main()
    {
        // Creating an object of the Car class
        Car myCar = new Car();

        // Setting object properties
        myCar.SetCarDetails("Toyota", "Innova", 2024);

        // Accessing object properties
        Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");

    }
}
