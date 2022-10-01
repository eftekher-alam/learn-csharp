using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReadyToGo_WhileLoop_
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ready = "";
            while( ready.ToUpper() != "R")
            {

                Console.Write("Enter to increase passanger or press 'R' to run bus. :");
                ready = Console.ReadLine();               
                counter++;
                Console.WriteLine("Passanger counted : " + counter);
            }
            Console.WriteLine("Bus is running......");
            Console.Read();
        }
    }
}
