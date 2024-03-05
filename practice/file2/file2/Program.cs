using System;

// Partial class defined in File2.cs
public partial class MyClass
{
    public void Method2()
    {
        Console.WriteLine("Method2 from File2.cs");
    }
}

// Main program in File2.cs
class Program2
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.Method2();

        Console.ReadLine();

    }
}
