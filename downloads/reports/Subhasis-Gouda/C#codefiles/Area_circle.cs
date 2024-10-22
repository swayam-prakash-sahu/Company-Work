using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double radius;
            Console.Write("Enter the radius of circle");
            radius=double.Parse(Console.ReadLine());
            double area = pi * radius * radius;
            Console.Write("The Area of the given Circle is " + area);
            Console.Read();
        }
    }
}