using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Sum(12, 8);
            Console.WriteLine("Sum = " + result);

            string massage = MassagePrint("welcome to our hotel.");
            Console.WriteLine(massage);
           
            //Challange 1
            Console.WriteLine(GreetFriends("Manik"));

            Console.Read();
        }

       
        public static double Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static string MassagePrint(string m)
        {
            string name = "Eftekher";

            return name + ", " +m;
        }

        public static string GreetFriends(string name)
        {
            return "Hi " + name + ", my friend!";
        }
    }
}
