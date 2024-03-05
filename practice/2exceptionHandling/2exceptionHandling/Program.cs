using System;

class ExceptionHandlingExample
{
    static void Main()
    {
        try
        {
            // Some code that may throw different types of exceptions
            int result = DivideNumbers(10, 0);
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero");
            Console.WriteLine("Exception Details: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Input format is incorrect");
            Console.WriteLine("Exception Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred");
            Console.WriteLine("Exception Details: " + ex.Message);

            // Rethrowing the exception
            throw;
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }

        Console.WriteLine("Program continues after exception handling");

        Console.ReadLine();
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
