using System;

// Define a generic delegate type
public delegate void MyGenericDelegate<T>(T value);

// Define a class with methods that match the delegate signature
public class EventPublisher
{
    public static void Method1(int x)
    {
        Console.WriteLine($"Method1: {x}");
    }

    public static void Method2(string s)
    {
        Console.WriteLine($"Method2: {s}");
    }

    public static void Method3(string d)
    {
        Console.WriteLine($"Method3: {d}");
    }
}

class Program
{
    static void Main()
    {
        // Single Delegate Example
        MyGenericDelegate<int> singleDelegate = EventPublisher.Method1;
        singleDelegate(42);

        // Multicast Delegate Example
        MyGenericDelegate<string> multicastDelegate = EventPublisher.Method2;
        multicastDelegate += EventPublisher.Method3;

        // Invoking the multicast delegate will call all methods in the list
        multicastDelegate("Multicaste delegate");

        // Removing a method from the multicast delegate
        multicastDelegate -= EventPublisher.Method2;
        multicastDelegate("Removed method2 from multicast delegate");

        Console.ReadLine(); // To keep the console window open
    }
}
