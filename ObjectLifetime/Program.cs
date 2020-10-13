using System;
using System.ComponentModel.DataAnnotations;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //Example of using overloaded constructor
            Car myThirdCar = new Car("Ford", "Explorer", 2020, "Blue");

            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";


            Car myOtherCar;
            myOtherCar = myCar; //They are both pointed to the same bucket in memory here. If you rename with with tag, tehy both change.

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Contructor
        public Car()
        {
            Make = "Nissan"; //This automatically sets every new instance of car make to Nissan without doing so manually.
        }

        //Overloaded contructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
