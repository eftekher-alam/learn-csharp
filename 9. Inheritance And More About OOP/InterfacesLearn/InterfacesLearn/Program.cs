using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var M1 = new Man();
            M1.Name = "Eftekher Alam";
            M1.Age = 24;
            M1.Weight = 50;
            M1.Work();
            M1.Eat();

            List<Man> bag = new List<Man>();
            bag.Add(M1);

            foreach(var x in bag)
            {
                Console.WriteLine(x.Name);
            }

            Console.ReadKey();
        }
    }
}
