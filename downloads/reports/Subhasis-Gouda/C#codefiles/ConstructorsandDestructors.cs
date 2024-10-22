using System;

public class Cars
{
    private string _name;

    // Constructor
    public Cars(string name)
    {
        _name = name;
        Console.WriteLine($"Constructor is called. {_name} is created.");
    }

    // Destructor
    ~Cars()
    {
        Console.WriteLine($"Destructor is called. {_name} is destroyed.");
    }

    // Method to display the object's name
    public void Display()
    {
        Console.WriteLine($"Object name: {_name}");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects
        Cars c1 = new Cars("Object1");
        Cars c2 = new Cars("Object2");

        // Calling Display methods
        c1.Display();
        c2.Display();

        // Objects go out of scope and destructor executes
    }
}
