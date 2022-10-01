using System;
namespace DelegatesLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of "runs" delegate pointing to those method
            runs runAdd = Add;
            runs runReminder = Reminder;
            runs runSub = Sub;

            //Here, I called three methode in together in 18 line, 5 & 3 will puss into three methode together;
            runs codeRun = runAdd + runReminder + runSub;
            codeRun(5, 3);
            Console.ReadLine();
        }

        public delegate int runs(int a, int b);

        public static int Add(int x, int y)
        {
            Console.WriteLine($"The sum is : {x + y}");
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            Console.WriteLine($"The subtraction is : {x - y}");
            return x % y;
        }

        public static int Reminder(int x, int y)
        {
            Console.WriteLine($"The Reminder is : {x % y}");
            return x % y;
        }


    }
}
