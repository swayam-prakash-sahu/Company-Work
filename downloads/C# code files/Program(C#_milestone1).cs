using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");

            //  \" escape sequence

            Console.WriteLine("Hello \"World\"!");

            // you use the \\ to display a single backslash

            Console.WriteLine("c:\\source\\repos");

            //Verbatim string literal

            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

           // Unicode escape characters

         Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // string concatenation
            string firstName = "Bob";
            string greeting = "Hello";
            string message = greeting + " " + firstName + "!";

            Console.WriteLine(message);

            // string interpolation
            string mesage = $"{greeting} {firstName}!";
            Console.WriteLine(mesage);

            string fN = "Bob";
            string msg = $"Hello {fN}!";
            Console.WriteLine(msg);

            //string interpolation with multiple variables and literal strings
            int version = 11;
            string updateText = "Update to Windows";
            string msge = $"{updateText} {version}";
            Console.WriteLine(msge);

            //Combine verbatim literals and string interpolation
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            //Mix data types to force implicit type conversions

            string fName = "Ram";
            int widgetsSold = 7;
            Console.WriteLine(fName + " sold " + widgetsSold + " widgets.");
            // a more advanced case of adding numbers and concatenating strings
            Console.WriteLine(fName + " sold " + widgetsSold + 7 + " widgets.");
            // Add parentheses to clarify your intention to the compiler
            Console.WriteLine(fName + " sold " + (widgetsSold + 7) + " widgets.");

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            // code to perform division using literal decimal data
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");

           // Add code to cast results of integer division
            int first = 7;
            int second = 5;
            decimal quo_tient = (decimal)first / (decimal)second;
            Console.WriteLine(quo_tient);

            // determine the remainder after integer division

            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");


            // code to exercise C#'s order of operations

            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);


            // increment and decrement operators
            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);


            //increment operator before and after the value
            //int value1 = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            Console.WriteLine($"Second: {value++}");

            Console.WriteLine("Fourth: " + (++value));

            // fahrenheit to Celsius
            int fahrenheit = 94;
            decimal Celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + Celsius + " Celsius.");

            Console.WriteLine(5 / 10);



            Console.ReadLine();

        }
    }
}
