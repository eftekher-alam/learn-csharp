using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci 1 + 1 + 2 + 3 + 5 + 8 
            int n = 9, i = 1, first = 0, second = 1;
            int fib = first + second; //fib = 0+1 = 1 which is 1st position of fibonacci SO, loop should start from 2nt position.
            Console.Write(fib + " + ");
            while(i < n)
            {
                Console.Write(fib);
                if(i < n-1)
                Console.Write(" + ");
                first = second;
                second = fib;
                fib = first + second;
                i++;
            }
            Console.ReadKey();
        }
    }
}
