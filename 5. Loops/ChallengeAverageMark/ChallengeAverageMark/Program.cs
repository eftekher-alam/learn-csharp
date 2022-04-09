using System;
using System.Numerics;

namespace ChallengeAverageMark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge 7, Chapter 5(Loops)
            int input = 0, i = 0, sumOfMarks = 0;
            while (input != -1)
            {

                Console.Write("Enter mark or to stop enter -1 : ");
            enter:
                if (int.TryParse(Console.ReadLine(), out input) && input >= 0 && input <= 20)
                {
                    sumOfMarks += input;
                }
                else if (input == -1)
                    //continue;
                    Console.WriteLine("Everage Marks : " + sumOfMarks / i);
                else
                {
                    Console.Write("Please enter currect input between 0 to 20 :");
                    goto enter;
                }
                i++;
            }
            //Console.WriteLine("Everage Marks : " + sumOfMarks / i);
            Console.Read();
        }
    }
}
