using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendName = { "Eftkeher", "Alam", "Sakib", "Atik", "Ashik" };

            Console.Write("My friends are : ");
            foreach (string name in friendName)
            {
                Console.Write("{0}, ", name);
            }

            Console.WriteLine(friendName.Length); //to find length
            Console.WriteLine(friendName.Rank); //to find dimantion

            Console.ReadKey();

        }
    }
}
