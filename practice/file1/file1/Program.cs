using System;

// Partial class defined in File1.cs
public partial class MyClass
{
    public void Method1()
    {
        Console.WriteLine("Method1 from File1.cs");
    }
}

// Main program in File1.cs
class Program1
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.Method1();

        Console.ReadLine();
    }
}
