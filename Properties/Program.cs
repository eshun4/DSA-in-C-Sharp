// See https://aka.ms/new-console-template for more information
using System;


namespace ExampleProj
{
    public class Program
    {
        private string name;


        public string Name{
            get { return name; }
            // set { name = value; }
        }

        public Program(string name)
        {
            this.name = name;
        }

        static void Main(string[] args)
        {
            Program person = new Program("John Doe");
            // person.Name = "Kofi"; // Setter is commented out, so this line would not work
            Console.WriteLine($"Name is: {person.Name}");
        }
    }
}