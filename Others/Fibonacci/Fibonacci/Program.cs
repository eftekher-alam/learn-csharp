using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci(5);
            Console.ReadKey();
        }

        public static List<int> fibonacci(int n)
        {
            List<int> result = new List<int>();
            int x = 0;
            while(n >= 0)
            {
                x += n;
                n--;
                Console.WriteLine(x);
            }
                
            return result;
        }
    }
}
