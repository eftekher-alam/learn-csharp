using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfSealed
{
    class X:W
    {
        private string name = "X";
        sealed protected override void Details()
        {
            Console.WriteLine("I am from derived class : " + name);
        }
    }
}
