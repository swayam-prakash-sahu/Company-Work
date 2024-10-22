using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci series you want to print: ");
            int n = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
