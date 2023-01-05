using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupledDriver
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is started.");
        }
    }
}
