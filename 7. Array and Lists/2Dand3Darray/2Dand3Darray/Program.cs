using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dand3Darray
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D Array
            int[,] numbers = { 
                {1, 2, 3, 4, 5}, 
                {1, 2, 3, 4, 5}, 
                {1, 2, 3, 4, 5}, 
                { 1, 2, 3, 4, 50 } };

            Console.WriteLine("3D array : " + numbers[3, 4]);

            //3D array
            int[,,] id =
            {
                { 
                    {1, 2, 3, 4, 5}, 
                    {1, 2, 3, 4, 5}, 
                    {1, 2, 3, 4, 5},  
                },
                {
                    {1, 2, 3, 4, 5},
                    {1, 2, 33, 4, 5},
                    {1, 2, 3, 4, 5},
                }
            };
            Console.WriteLine("3D array : " + id[1, 1, 2]);

            Console.Read();
        }
    }
}
