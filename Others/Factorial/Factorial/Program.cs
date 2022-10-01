using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadKey();
        }

        static int factorial(int n)
        {
            if(n == 1)
            {
                return n;
            }
            return n * factorial(n - 1);
        }
    }
}
