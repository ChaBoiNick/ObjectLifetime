using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Holden";
            myCar.Model = "Commodore";
            myCar.Year = 2008;
            myCar.Colour = "Blue";

            Car mySecondCar = new Car();

            mySecondCar.Make = "Ford";
            mySecondCar.Model = "";

            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

    }
}
