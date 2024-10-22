using System;

// Base class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Derived class
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of derived classes
        Shape shape1 = new Circle();
        shape1.Draw();

        Shape shape2 = new Rectangle();
        shape2.Draw();
    }
}

using System;

// Base class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Derived class from Circle
public class ColoredCircle : Circle
{
    public void Color()
    {
        Console.WriteLine("Circle is colored");
    }
}

class Program
{
    static void Main()
    {
        ColoredCircle coloredCircle = new ColoredCircle();
        coloredCircle.Draw(); // Calls the Draw method of Circle
        coloredCircle.Color(); // Calls the Color method of ColoredCircle
    }
}


using System;

// Base class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class 1
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Derived class 2
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw(); // Calls the Draw method of Circle

        Rectangle rectangle = new Rectangle();
        rectangle.Draw(); // Calls the Draw method of Rectangle
    }
}
