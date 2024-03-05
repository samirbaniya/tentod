using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo3
{
    internal class Program
    {
        // FunctionOverloading with different types of parameters
        public static void DiffTypes(int a)
        {
            Console.WriteLine($"Integer value: {a}");
        }

        public static void DiffTypes(double a)
        {
            Console.WriteLine($"Double value: {a}\n");
        }

        // FunctionOverloading with different number of parameters
        public static int diffNum(int a, int b)
        {
            return a + b;
        }

        public static int diffNum(int a, int b, int c)
        {
            return a + b + c;
        }

        // FunctionOverloading with the order of arguments
        public static void DiffOrder(string name, int rollNo)
        {
            Console.WriteLine($"\nName: {name} Roll No.: {rollNo}");
        }

        public static void DiffOrder(int rollNo, string name)
        {
            Console.WriteLine($"Name: {name} Roll No.: {rollNo}");
        }

        static void Main()
        {
            // Example of different types of parameters
            DiffTypes(15);
            DiffTypes(22.79);

            // Example of different number of parameters
            Console.WriteLine("Sum of two numbers: " + diffNum(99, 20));
            Console.WriteLine("Sum of three numbers: " + diffNum(99, 20, 15));

            // Example of the order of arguments
            DiffOrder("Rajan", 17);
            DiffOrder(17, "Rajan");

            Console.ReadLine();
        }

    }
}
