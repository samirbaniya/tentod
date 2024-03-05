using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start of program");

        // Calling an asynchronous method with await
        await DoSomethingAsync();

        Console.WriteLine("End of program");
        Console.ReadLine();

    }

    static async Task DoSomethingAsync()
    {
        Console.WriteLine("Start of asynchronous method");

        // Simulating an asynchronous operation, such as an HTTP request
        string result = await SimulateAsyncOperation();

        Console.WriteLine($"Asynchronous operation result: {result}");

        Console.WriteLine("End of asynchronous method");
    }

    static async Task<string> SimulateAsyncOperation()
    {
        Console.WriteLine("Start of simulated asynchronous operation");

        // Simulating an asynchronous operation, such as an HTTP request
        using (HttpClient httpClient = new HttpClient())
        {
            // Simulating an asynchronous HTTP request
            HttpResponseMessage response = await httpClient.GetAsync("https://www.example.com");
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        // This line will never be reached, but a value is required for the method signature
        return "Default Result";

    }
}
