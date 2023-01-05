using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupledDriver
{
    internal class Driver
    {
        private readonly IVehicle vehicle;
        public Driver(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void StartVehicle()
        {
            vehicle.Start();
        }
    }
}
