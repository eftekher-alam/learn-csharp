using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    class Program
    {
        const string dateOfBirth = "08 Jun 1997";
        static void Main(string[] args)
        {
            const int day = 30; //It cannot change after diclaration.

            //day = 50; //It will show error because it is constant variable

            //dateOfBirth = "shuvo";

            string id = "20";
            int num = int.Parse(id);
            Console.WriteLine(num);


            Console.WriteLine(dateOfBirth);
            Console.ReadKey();
        }
    }
}
