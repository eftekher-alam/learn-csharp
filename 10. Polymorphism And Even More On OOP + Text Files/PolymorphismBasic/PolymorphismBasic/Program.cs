using System;
using System.Collections.Generic;

namespace PolymorphismBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new BMW(10, "Blue", "A4");
            car.ShowDetails();
            car.Repair();

            //Object stored in list
            //var cars = new List<Car>()
            List<Car> cars = new List<Car>()
            {
                new Audi(14, "Black", "AD430"),
                new BMW(30, "White", "B293")
            };

            foreach(var x in cars)
            {
                x.Repair();
            }
            Console.ReadKey();
        }
    }
}
