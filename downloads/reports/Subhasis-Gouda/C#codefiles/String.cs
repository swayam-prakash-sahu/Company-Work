using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          string x,y;
          x="Hello";
          y="World";
          Console.Write(x+" "+y);

          string fruit="Apple";
          Console.Write(fruit);

          string num1 = "25";
          string num2 = "69";
          Console.Write(num1 + num2);

          string word = "Programming";
          Console.WriteLine(word[2]);
          Console.Write(word[4]);

          string s = Console.ReadLine();
          Console.Write("Your name is: " + s);

          //Console.ReadLine() returns the user input as a string
          //We have to convert that string to an integer using Convert.ToInt32()
          int a = Convert.ToInt32(Console.ReadLine());
          Console.Write("Your number is: " + a);
          
          int a = Convert.ToInt32(Console.ReadLine());
          int b = Convert.ToInt32(Console.ReadLine());
          int sum, diff;
          sum = a+b;
          diff= a-b;
          Console.WriteLine("Sum is: "+ sum +"\n"+ "Difference is: "+ diff);

          int a = Convert.ToInt32(Console.ReadLine());
          int b = Convert.ToInt32(Console.ReadLine());
          int c = a + 2;
          int d = c + b;
          Console.Write(d);

          string x = Console.ReadLine();
          Console.Write("Hello " + x);

          Console.Read();
        }
    }
}