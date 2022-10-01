using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Program
    {
        //Lamda expression will create by using the delegate
        delegate double Calculator(int a, int b);
        static void Main(string[] args)
        {
            //It is a lamda expression which name is "claculator"
            //It is multi statements lamda expression
            //(x, y) takes as parameters cause delegate requirt two parameters
            //It must return double type vaue cause delecate's return type is double
            Calculator calculator = (x, y) => {
                Console.WriteLine($"The sum is : {x + y}");
                return x + y;
            };
            //Here I called calculator lamda expression
            //I can store the return value by the code: double result = calculator(10, 20)
            calculator(10, 20);


            //Single statement lamda expression
            //Here, (num1, num2) this part is parameter as the delegate requirt
            //Although in the part, num1 - num2 doesn't contain return keyword but it will return as the delegate requirt
            Calculator calculator1 = (num1, num2) => num1 - num2;

            double result = calculator1(12, 15);
            Console.WriteLine($"Amar calculator1 er uttor : {result}");

            Console.ReadKey();
        }
    }
}
