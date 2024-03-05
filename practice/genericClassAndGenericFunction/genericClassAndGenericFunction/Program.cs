using System;

public class GenericClass<T>
{
    public T Generic;

    public GenericClass(T a)
    {
        Generic = a;
    }
}

class Program
{
    // Generic function
    public static void DisplayValue<T>(T a)
    {
        Console.WriteLine($"Generic Function value: {a}");
    }
    static void Main()
    {
        // Example with int
        GenericClass<int> intobj = new GenericClass<int>(42);
        Console.WriteLine($"Generic class Value: {intobj.Generic}");

        // Example with string
        GenericClass<string> stringobj = new GenericClass<string>("Generic class");
        Console.WriteLine($"Generic class Value: {stringobj.Generic}");

        Console.WriteLine();

        // Explicitly specifying type <int>
        DisplayValue<int>(42);

        // Explicitly specifying type <string>
        DisplayValue<string>("Generic Function");

        // Explicitly specifying type <double>
        DisplayValue<double>(3.14);

        Console.ReadLine();
    }
}
