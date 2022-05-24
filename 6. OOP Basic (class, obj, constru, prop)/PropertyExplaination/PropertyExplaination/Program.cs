using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExplaination
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member();

            m1.Name = "Eftekher Alam";
            m1.Phone = 01790303459;

            Console.WriteLine("Name of member : " + m1.Name);
            Console.WriteLine("Phone number of the member : " + m1.Phone);

            Console.ReadKey();
        }
    }
}
