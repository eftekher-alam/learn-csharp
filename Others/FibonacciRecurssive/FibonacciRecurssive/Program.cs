using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecurssive
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 9;
            //Find fibonacci value only for 9th position
            Console.WriteLine("9th Position Value is : " + Fib(n));


            //Generate fibonacci from 1st to 9th position
            List<int> result = new List<int>();
            while (n > 0)
            {
                result.Add(Fib(n));
                n--;
            }
            result.Reverse();
            result.ForEach(x => Console.Write(x + "+"));
            Console.ReadKey();
        }
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

    }
}
