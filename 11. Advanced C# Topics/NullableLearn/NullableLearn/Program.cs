using System;
namespace NullableLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int? phoneNo1 = null;
            int? phoneNo2 = 01790;
            int phoneno3 = 01912;
            double? salary = null;
            double? salary1 = 2000.011;
            Console.WriteLine(salary1);

            test(phoneNo1);
            test(phoneno3);
            Console.ReadKey();

        }

        public static void test(int? phon)
        {
            if(phon.HasValue)
            {
                Console.WriteLine("Phone number is : " + phon);
            }
            else
            {
                Console.WriteLine("There is no value.");
            }
        }
    }
}
