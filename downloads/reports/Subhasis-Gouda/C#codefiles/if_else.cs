using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 25;
            int Vage = 18;
            
            if(Age < Vage)
            {
                Console.WriteLine("Not old enough to vote.");
                Console.Write("Wait for " + (Vage - Age) + " years");
            }
            else
            {
                Console.Write("Old enough to vote!");
            }

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                Console.Write("Coding is Fun!");
            }

            int r = 45;
            int b = 23;
            if(r > b)
            {
                Console.WriteLine("Rob Scored higher marks than Bob.");
            }
            else if(r == b)
            {
                Console.WriteLine("Bob & Rob both scored the same");
            }
            
        }
    }
}