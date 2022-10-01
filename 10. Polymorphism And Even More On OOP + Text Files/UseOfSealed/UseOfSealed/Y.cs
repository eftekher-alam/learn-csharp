using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfSealed
{
    sealed class Y:X
    {
        private string name = "X";
        //Can not be voerride cause it is a sealed mehtod.
        //protected override void Details()
        //{
        //    Console.WriteLine("I am from derived class : " + name);
        //}
    }
}
