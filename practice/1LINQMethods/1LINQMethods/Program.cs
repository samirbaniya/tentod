using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample data
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtering using Lambda Expression
        var filteredNumbersLambda = numbers.Where(x => x % 2 == 0);
        Console.WriteLine("Filtering using Lambda Expression:");
        PrintList(filteredNumbersLambda);

        // Filtering without Lambda Expression
        var filteredNumbersWithoutLambda = from num in numbers
                                           where num % 2 == 0
                                           select num;
        Console.WriteLine("\nFiltering without Lambda Expression:");
        PrintList(filteredNumbersWithoutLambda);

        // Sorting using Lambda Expression
        var sortedNumbersLambda = numbers.OrderBy(x => x);
        Console.WriteLine("\nSorting using Lambda Expression:");
        PrintList(sortedNumbersLambda);

        // Sorting without Lambda Expression
        var sortedNumbersWithoutLambda = from num in numbers
                                         orderby num
                                         select num;
        Console.WriteLine("\nSorting without Lambda Expression:");
        PrintList(sortedNumbersWithoutLambda);

        // Aggregation using Lambda Expression
        var sumLambda = numbers.Sum();
        Console.WriteLine($"\nAggregation using Lambda Expression - Sum: {sumLambda}");

        // Aggregation without Lambda Expression
        var sumWithoutLambda = (from num in numbers
                                select num).Sum();
        Console.WriteLine($"Aggregation without Lambda Expression - Sum: {sumWithoutLambda}");

        // Projection using Lambda Expression
        var squaredNumbersLambda = numbers.Select(x => x * x);
        Console.WriteLine("\nProjection using Lambda Expression:");
        PrintList(squaredNumbersLambda);

        // Projection without Lambda Expression
        var squaredNumbersWithoutLambda = from num in numbers
                                          select num * num;
        Console.WriteLine("\nProjection without Lambda Expression:");
        PrintList(squaredNumbersWithoutLambda);

        // Concatenation using Lambda Expression
        Func<IEnumerable<int>> generateSecondList = () => new List<int> { 11, 12, 13 };

        var combinedNumbersLambda = numbers.Concat(generateSecondList());
        Console.WriteLine("\nConcatenation using Lambda Expression:");
        PrintList(combinedNumbersLambda);


        // Concatenation without Lambda Expression
        var combinedNumbersWithoutLambda = numbers.Concat(new List<int> { 11, 12, 13 });
        Console.WriteLine("\nConcatenation without Lambda Expression:");
        PrintList(combinedNumbersWithoutLambda);

        // Join using Lambda Expression
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Emily" };
        var joinedDataLambda = numbers.Join(names, num => num % 5, name => name.Length, (num, name) => $"{name}: {num}");
        Console.WriteLine("\nJoin using Lambda Expression:");
        PrintList(joinedDataLambda);

        // Join without Lambda Expression
        var joinedDataWithoutLambda = from num in numbers
                                      join name in names on num % 5 equals name.Length
                                      select $"{name}: {num}";
        Console.WriteLine("\nJoin without Lambda Expression:");
        PrintList(joinedDataWithoutLambda);

        // Quantifiers using Lambda Expression
        bool anyEvenLambda = numbers.Any(x => x % 2 == 0);
        Console.WriteLine($"\nQuantifiers using Lambda Expression - Any even number: {anyEvenLambda}");

        // Quantifiers without Lambda Expression
        bool anyEvenWithoutLambda = (from num in numbers
                                     where num % 2 == 0
                                     select num).Any();
        Console.WriteLine($"Quantifiers without Lambda Expression - Any even number: {anyEvenWithoutLambda}");

        Console.ReadLine();
    }

    static void PrintList<T>(IEnumerable<T> list)
    {
        foreach (var item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
