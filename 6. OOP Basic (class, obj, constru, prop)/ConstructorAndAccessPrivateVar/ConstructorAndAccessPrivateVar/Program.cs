using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndAccessPrivateVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Eftekher", "Shuvo", "Blue", 21);
            //It dosn't work cz firstName is private var of Human class
            //h1.firstName = "Eftekher";
            h1.Introduce();
            Console.ReadKey();
        }
    }
}
