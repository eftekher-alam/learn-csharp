using System;

namespace ConversionExplicitAndImplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            /* >>>>>>>>> Implicit Conversion <<<<<<<<<<
                1. small to big (int to long)
                2. there is no chance to losing data.
                3. convert child class obj to parent class obj. (cat to animal)
            */

            int n = 1000;
            long m = (long)n;
            Console.WriteLine(n);

            /*
             Derived d = new Derived();

             // Always OK.
             Base b = d;

             */



            /* >>>>>>>>> Explicit converison <<<<<<<<<<<<<
                1. There is chance to losing data (double to int,  59.78 to 59, .78 data losing here)
                2. conver parent class obj to child class obj. (animal to cat)
             */
            long bigAmount = 13000000000000;
            Console.WriteLine(bigAmount);

            int smallAmout = (int)bigAmount;
            Console.WriteLine(smallAmout);

            float data1 = 34.808F;
            int data2 = (int)data1;
            Console.WriteLine(data2);
            
            /*
            // derived 
            Giraffe g = new Giraffe();

            Giraffe g2 = (Giraffe)a;
            // Explicit conversion is required to cast back
            // to derived type. Note: This will compile but will
            // throw an exception at run time if the right-side
            // object is not in fact a Giraffe.

            */

            Console.ReadKey();

          

        }


    }
}
