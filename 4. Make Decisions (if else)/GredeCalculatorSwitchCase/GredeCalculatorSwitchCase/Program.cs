using System;

namespace GredeCalculatorSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks : ");
            switch (int.Parse(Console.ReadLine()) / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A+");
                    break;
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                    Console.WriteLine("D");
                    break;
                case 4:
                    Console.WriteLine("E");
                    break;
                default:
                    Console.WriteLine("F");
                    break;

            }
            Console.Read();
        }
       
    }
}
