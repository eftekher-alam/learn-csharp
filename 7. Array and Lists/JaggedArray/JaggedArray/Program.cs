using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Way 1
            int[][] jaggedArray = new int[3][]; //here 4 arrays will be stored.

            jaggedArray[0] = new int[5]; //in the position 0 of jagged array will take a array which length is 5
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];

            //initialization value
            jaggedArray[0] = new int[] { 10, 20, 30, 40, 50 }; // if gives more than 5 value error will be out of bound
            jaggedArray[1] = new int[] { 12, 13 };

            foreach(var i in jaggedArray[1])
            {
                Console.WriteLine(i);
            }

            //Way 2

            int[][] jaggedArray2 = new int[2][]
            {
                new int[]{10,20},
                new int[]{20, 70, 100}
            };

            Console.WriteLine("All value of jagged Array2 : ");
            foreach (var i in jaggedArray2)
            {
                Console.WriteLine("Value of array which length : " + i.Length);
                foreach(var x in i)
                {
                    Console.WriteLine(x);
                }                
            }



            Console.ReadKey();

        }
    }
}
