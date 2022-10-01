using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter makrs :");
            Console.WriteLine("You got : " + Calculator(int.Parse(Console.ReadLine())));
            Console.Read();

        }
        public static string Calculator(int marks)
        {
            if (marks > 100)
            {
                return "Given input is not correct..!";
            }
            else if (marks >= 90)
            {
                return "A";
            }
            else if (marks >= 80)
            {
                return "B";
            }
            else if (marks >= 80)
            {
                return "B";
            }
            else if (marks >= 70)
            {
                return "C";
            }
            else if (marks >= 60)
            {
                return "D";
            }
            else if (marks >= 40)
            {
                return "E";
            }
            if (marks < 40)
            {
                return "F";
            }
            else
            {
                return "Given input is not correct..!";
            }

        }
    }
}
