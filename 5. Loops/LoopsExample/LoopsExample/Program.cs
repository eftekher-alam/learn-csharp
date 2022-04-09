using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            Console.WriteLine(">>>>>>>>>>>> for loop <<<<<<<<<<<<<");
            for(int counter = 10; counter >= 0; counter--)
            {
                Console.WriteLine(counter);
            }

            //while loop
            Console.WriteLine(">>>>>>>>>>>> while loop <<<<<<<<<<<<<");
            int i = 0;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while loop
            Console.WriteLine(">>>>>>>>>>>> do while loop <<<<<<<<<<<<<");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);

            Console.Read();
        }
    }
}
