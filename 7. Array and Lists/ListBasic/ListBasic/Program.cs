using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List can have same type of element.It is mutable means
            * if we create a list it will take a memory address and
             * if we modify this list it will use the same memory address. 
             *Where as immutable like array,
             * if we modify the array takes new memory address to store after modify.*/

            //Way - 1
            List<int> grads = new List<int>();
            grads.Add(2);
            grads.Add(30);
            grads.Add(5);

            grads.Sort();
            grads.Reverse();

            grads.ForEach(x => Console.WriteLine(x)); //lamda expression of foreeach for list

            //way - 2
            List<int> numbers = new List<int> { 10, 100, 200, 20};
            grads.Add(10); // It will add as last item

            grads.ForEach(x => Console.WriteLine("Way2 " + x));

            Console.ReadKey();
        }

    }
}
