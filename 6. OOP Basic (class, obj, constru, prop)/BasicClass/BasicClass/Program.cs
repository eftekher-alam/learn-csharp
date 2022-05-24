using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object/instance of human class
            Human H1 = new Human();
            //eccess public variable of human class outside of the class
            H1.firstName = "Eftekher";
            H1.lastName = "Shuvo";
            // call public function of human class outside of the class
            H1.Introduction();

            Human H2 = new Human();
            H2.firstName = "Khelada";
            H2.lastName = "Begum";
            H2.Introduction();

            Console.ReadKey();
        }
    }
}
