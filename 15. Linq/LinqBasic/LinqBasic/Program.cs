using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 14, 30, 12 };
            IEnumerable<int> result = from number in numbers where number > 10 orderby number descending select number;

            foreach (var item in result)
            {
                Console.WriteLine($"Bigger than 10 are : {item}");
            }

            string[] names =  { "Eftekher", "Shuvo", "Arithmatic", "Automation", "Football" };
            IEnumerable<string> nameOP = from name in names 
                                         where name.ToLower().Contains("o")
                                         select name;

            foreach (var item in nameOP)
            {
                Console.WriteLine("Names which contain  a : " + item);
            }

            Console.ReadLine();
        }
    }
}
