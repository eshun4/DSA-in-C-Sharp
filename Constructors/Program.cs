// See https://aka.ms/new-console-template for more information
using System;



namespace ExampleProj
{
    public class Program
    {

        int exampleNumber;
        string? exampleName;

        public Program(int number)
        {
            exampleNumber = number;
        }

        public Program(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

        static void Main(string[] args)
        {
            // Create an instance of Program with a specific number
            Program example = new Program(42);
            Console.WriteLine($"Example number is: {example.exampleNumber}");

            // You can also create another instance with a different number
            Program anotherExample = new Program(100, "John");
            Console.WriteLine($"Another example number is: {anotherExample.exampleNumber} and another example name is: {anotherExample.exampleName}");
            
        }
    }
}