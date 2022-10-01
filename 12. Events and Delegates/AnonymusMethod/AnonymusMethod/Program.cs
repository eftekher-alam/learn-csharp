using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethod
{
    class Program
    {
        //This is delegate by which anonymous method will be created
        delegate string MyDelegate(string x);
        static void Main(string[] args)
        {
            //It is an anonymous method which name is greeting.
            MyDelegate greeting = delegate (string name) {
                return "Ami anonymous method, soveccha Mr. " + name;
            };

            Console.WriteLine(greeting("Eftekher"));

            //called normal method and puss a anonymous method as parameter
            ami(greeting);
            Console.ReadKey();
        }

        //we can puss anonymous method as parameter in normal method
        static void ami(MyDelegate myDelegated)
        {
            Console.WriteLine(myDelegated("Shuvo"));
        }
    }
}
