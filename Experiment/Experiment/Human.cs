using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Human
    {
        public static int NID = 11501;
        public int Age { get; set; }

        public override string ToString()
        {
            return "My age is : " + Age + "\nAnd This is my NID : " + NID;
        }
        public void Display()
        {
            Console.WriteLine(NID);
        }

    }
}
