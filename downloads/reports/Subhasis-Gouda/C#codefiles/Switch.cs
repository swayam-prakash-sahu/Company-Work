using System;
namespace SwitchCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int input = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered one.");
                    break;
                case 2:
                    Console.WriteLine("You entered two.");
                    break;
                case 3:
                    Console.WriteLine("You entered three.");
                    break;
                case 4:
                    Console.WriteLine("You entered four.");
                    break;
                case 5:
                    Console.WriteLine("You entered five.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
