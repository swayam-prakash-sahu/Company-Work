using System;

public class Car
{
    // Public field
    public string Make;

    // Private field
    private string _model;

    // Protected field
    protected int Year;

    // Internal field
    internal string Color;

    // Protected internal field
    protected internal double Price;

    // Constructor
    public Car(string make, string model, int year, string color, double price)
    {
        Make = make;
        _model = model;
        Year = year;
        Color = color;
        Price = price;
    }

    // Public method
    public void DisplayMake()
    {
        Console.WriteLine($"Make: {Make}");
    }

    // Private method
    private void DisplayModel()
    {
        Console.WriteLine($"Model: {_model}");
    }

    // Protected method
    protected void DisplayYear()
    {
        Console.WriteLine($"Year: {Year}");
    }

    // Internal method
    internal void DisplayColor()
    {
        Console.WriteLine($"Color: {Color}");
    }

    // Protected internal method
    protected internal void DisplayPrice()
    {
        Console.WriteLine($"Price: {Price}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Camry", 2022, "Red", 25000.50);

        // Accessing public members
        myCar.DisplayMake();

        // Accessing internal members is allowed because Program is in the same assembly
        myCar.DisplayColor();

        // Accessing protected internal members is allowed because Main is in the same assembly
        myCar.DisplayPrice();

        // Private and protected members cannot be accessed from outside the class
    }
}
