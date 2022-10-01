using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasic
{
    class BMW:Car
    {
        protected string Model { get; set; }
        private string Brand = "BMW";
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Brand = " + Brand + "\nModel = " + Model + "\nHP = " + HP + "\nColor = " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("BMW " + Model + " was repaired..!");
        }
    }
}
