using System;
namespace EnumLearn
{
    //By default value will start from 0;
    enum Day {SAT, SUN, MON, TUE, WED, THU, FRI}
    enum month { Jan = 1, Feb = 2000, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11 , Dec = 120000 }
    class Program
    {
        static void Main(string[] args)
        {
            var day = Day.FRI;
            Console.WriteLine(day);

            month monthName;
            Console.WriteLine((int)month.Dec);
            Console.ReadKey();
        }
    }
}
