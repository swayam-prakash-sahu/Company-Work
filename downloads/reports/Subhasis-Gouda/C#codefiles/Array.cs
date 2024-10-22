using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1, 2, 3, 4, 5};
            Console.WriteLine(num[2]);

            string[] months = {"Jan", "Feb", "Dec", "Apr"};
            months[2] = "Mar";
            Console.WriteLine(months[2]);

            int[] myNumber = {10,20,30,40,50,60};
            Console.WriteLine(myNumber.Length);
            
            // Multi-Dimensional Array
            int[,] matrix = new int[2, 3] {
                {1, 2, 3},
                {4, 5, 6}
            };
            Console.WriteLine("Multi-Dimensional Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {1, 2, 3};
            jaggedArray[1] = new int[] {4, 5};
            jaggedArray[2] = new int[] {6, 7, 8, 9};
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Param Arrays
            Console.WriteLine("\nParam Arrays:");
            DisplayNumbers(1, 2, 3);
            DisplayNumbers(4, 5, 6, 7, 8);
            DisplayNumbers(9, 10);

            Console.Read();
        }

    }
        static void DisplayNumbers(params int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    
}