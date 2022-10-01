using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousAnonymousAndLamda
{
    class Program
    {
        delegate void MyDelegate();
        delegate int MyDelegate1(int[] numbers);
        delegate int RanodemNums();
        static void Main(string[] args)
        {
            //void lamda
            //It won't return and won't take parameters
            MyDelegate dispaly = () => Console.WriteLine("Kmon Aco?");
            dispaly();

            //void anonymous mehtod
            //It won't return and won't take parameters
            MyDelegate myAnony = delegate()
            {
                Console.WriteLine("Ami Void Anonymous");
            };
            myAnony();


            int[] x = { 10, 10, 13 };
            //Lamda Expression(Multi Statements)
            MyDelegate1 delegate1 = nums => {
                int sum = 0;
                foreach (var item in nums)
                {
                    sum += item;
                }
                return sum;
            };
            int result = delegate1(x);
            Console.WriteLine("The lamda expression result is : " + result);


            //Anonymous Method(Multi Statements)
            MyDelegate1 delegate2 = delegate(int[] nums) {
                int sum = 0;
                foreach (var item in nums)
                {
                    sum += item;
                }
                return sum;
            };
            result = delegate2(x);
            Console.WriteLine("The anonymous method result is : " + result);


            
            RanodemNums randNum = () =>
            {
                Random random = new Random();
                return random.Next(1, 20);
            };
            Console.WriteLine("Our Rand No is : " + randNum());


            Console.ReadLine();
        }
    }
}
