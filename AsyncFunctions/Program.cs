// See https://aka.ms/new-console-template for more information
using System;

namespace AsyncFunctions
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Example of an asynchronous function
            await GreetAsync("Alice");

            // Another example with a different asynchronous action
            await SquareAsync(5);
        }

        private static async Task GreetAsync(string name)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Hello, {name}!");
            });
        }

        private static async Task SquareAsync(int number)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Square of {number} is {number * number}");
            });
        }
    }
}
