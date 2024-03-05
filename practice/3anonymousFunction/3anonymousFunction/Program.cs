using System;

class Program
{
    delegate void PrintDelegate(string message);

    static void Main()
    {
        // Using anonymous function with delegate
        PrintDelegate printDelegate = delegate (string message)
        {
            Console.WriteLine($"Delegate: {message}");
        };
        printDelegate("Hello from delegate!");

        // Using anonymous function with lambda expression
        Action<string> printLambda = message =>
        {
            Console.WriteLine($"Lambda Expression: {message}");
        };
        printLambda("Hello from lambda expression!");

        Console.ReadLine();

    }
}
