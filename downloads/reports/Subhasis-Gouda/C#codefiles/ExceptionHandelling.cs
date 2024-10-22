using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int index = 5;

        try
        {
            // Try to access an element outside the bounds of the array
            int value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            // Catch the exception if the index is out of range
            Console.WriteLine($"Index out of range: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Catch any other exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // This block is always executed, regardless of whether an exception occurred
            Console.WriteLine("Finally block executed.");
        }

        // Throwing a custom exception
        try
        {
            int result = Divide(10, 0);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new ArgumentException("Divisor cannot be zero.");
        }

        return dividend / divisor;
    }
}
