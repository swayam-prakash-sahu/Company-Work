using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,ctr=1;
            n=int.Parse(Console.ReadLine())+1;
            Console.WriteLine("First n natural numbers using do-while loop:");
            do
            {
                Console.Write(ctr + " ");
                ctr++;
            } while (ctr < n);
            Console.WriteLine();

            // while loop
            ctr = 1;
            Console.WriteLine("\n First n natural numbers using while loop:");
            while (ctr < n)
            {
                Console.Write(ctr + " ");
                ctr++;
            }
            Console.WriteLine();

            // for loop
            Console.WriteLine("\n First n natural numbers using for loop:");
            for (int i = 1; i < n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}
