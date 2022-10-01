using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionLearn
{
    class Cow : Animal
    {
        public override void AnimalSound()
        { 
            Console.WriteLine("Hamba Habma");
        }
    }
}
