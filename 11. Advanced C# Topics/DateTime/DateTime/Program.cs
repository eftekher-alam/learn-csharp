using System;

namespace DateTimeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var nextWeek = GetWeekLaterDate();
            Console.WriteLine(nextWeek);
            Console.WriteLine(DateTime.Today.DayOfWeek); 
            Console.ReadLine();
        }

        public static DateTime GetWeekLaterDate()
        {
            return DateTime.Today.AddDays(7);
        }
    }
}
