// See https://aka.ms/new-console-template for more information
using System;




namespace Proj
{
    public class AnonymousMethods
    {
        public static void Main(string[] args)
        {
            // Example of an anonymous method
            Action<string> greet = (string name) =>
            {
                Console.WriteLine($"Hello, {name}!");
            };

            // Invoke the anonymous method
            greet("Alice");

            // Another example with a different action
            Action<int> square = delegate (int number)
            {
                Console.WriteLine($"Square of {number} is {number * number}");
            };

            // Invoke the second anonymous method
            square(5);
            
            // Example using Func delegate with an anonymous method
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum of 3 and 4 is {add(3, 4)}");

            // Another example using Func with delegate keyword
            Func<string, int> getLength = delegate (string str)
            {
                return str.Length;
            };
            Console.WriteLine($"Length of 'Anonymous' is {getLength("Anonymous")}");
        }
    }
}