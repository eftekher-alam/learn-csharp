using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = new Random().Next(-5, 5);

            string classify;
            //if (input >= 0)
            //{
            //    classify = "nonnegative";
            //}
            //else
            //{
            //    classify = "negative";
            //}

                        //condition? consequent : alternative
            classify = (input >= 0) ? "nonnegative" : "negative";
            Console.WriteLine(classify);

            //enhance tarnary conditional operator
            input = new Random().Next(-10, 10);
            //if (input >= 0)
            //{
            //    classify = "nonnegative";                  
            //}
            //else if (input < 0)
            //{
            //    classify = "negative";
            //}
            //else
            //{
            //    classify = "Worng";
            //}

            classify = (input >= 0) ? "nonnegative" : (input < 0) ? "negative" : "wrong";
            Console.WriteLine(classify);
            Console.Read();
        }
    }
}
