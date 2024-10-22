using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Creating a hashtable
        Hashtable carModels = new Hashtable();

        // Adding car models to the Hashtable
        carModels.Add("Corolla", "Toyota");
        carModels.Add("Civic", "Honda");
        carModels.Add("Accord", "Honda");
        carModels.Add("Innova", "Toyota");
        carModels.Add("EcoSport", "Ford");
        carModels.Add("Mustang", "Ford");
        carModels.Add("R8", "Audi");
        carModels.Add("Q5", "Audi");
        carModels.Add("Explorer", "Ford");
        carModels.Add("CR-V", "Honda");

        // Iterating over the Hashtable
        foreach (DictionaryEntry entry in carModels)
        {
            Console.WriteLine($"Model: {entry.Key}, Manufacturer: {entry.Value}");
        }

        // Checking if a car model exists in the hashtable
        if (carModels.ContainsKey("Civic"))
        {
            Console.WriteLine(" yes the civic car exists in the hash table");
        }
    }
}
