// See https://aka.ms/new-console-template for more information
using System;


namespace ExmpleProj
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Create an instance of Car with specific attributes
            Car myCar = new Car(120, "Red", 25000.50f);
            Console.WriteLine("Car created with the following attributes:");
            myCar.Start();
            myCar.Drive();
            myCar.Stop();
        }

        public class Car
        {
            int speed;
            string color;
            float price;

            public Car(int speed, string color, float price)
            {
                this.speed = speed;
                this.color = color;
                this.price = price;
            }

            public void Start()
            {
                Console.WriteLine($"The car with speed {speed}, color {color}, and price {price} has started.");
            }

            public void Stop()
            {
                Console.WriteLine($"The car with speed {speed}, color {color}, and price {price} has stopped.");
            }

            public void Drive()
            {
                Console.WriteLine($"The car with speed {speed}, color {color}, and price {price} is driving.");
            }
        }
    }
}