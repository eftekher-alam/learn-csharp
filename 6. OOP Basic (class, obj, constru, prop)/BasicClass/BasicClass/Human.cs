using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Human
    {
        // member variable
        public string firstName, lastName;

        // member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName);
        }
    }
}
