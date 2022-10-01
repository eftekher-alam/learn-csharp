using System;

namespace OutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {

            int a; //no need to init first of a out Variable. But must initilize when it return.
            int b = 10;
            SetValueByRef(out a, ref b);
            Console.WriteLine($"After = a : {a}     b : {b}");
        }

        public static void SetValueByRef(out int x, ref int y)
        {
            x = 0;  //But must initilize when it return.
            y = 0; //It is optional to initialize.
        }
    }
}
