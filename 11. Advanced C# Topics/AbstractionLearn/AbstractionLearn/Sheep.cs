using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionLearn
{
    class Sheep : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Va Va Va");
        }
    }
}
