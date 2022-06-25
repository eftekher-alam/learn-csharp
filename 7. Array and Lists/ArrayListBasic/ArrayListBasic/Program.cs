using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //It act like a array but ArrayList is a class that can contain combination of multiple type of value.
            //way-1
            ArrayList storeHouse = new ArrayList() { "Eftkeher", 10, 69.200f, 1.00 };

            foreach (var x in storeHouse)
            {
                Console.WriteLine( "Values are : " + x);
            }

            Human h1 = new Human();

            h1.name = "Eftekher";
            h1.gender = "Male";
            h1.age = 22;

            storeHouse.Add(h1);

            foreach (var x in storeHouse)
            {
                Console.WriteLine(x);
            }

            int[] num = { 10, 20, 30, 40 };

           // Console.WriteLine("===>" + storeHouse[3]);
            Console.ReadLine();
        }
    }
    class Human
    {
        public string name, gender;
        public int age;
    }
}
