using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfSealed
{
    //Base Class
    class W
    {
        private string name = "W";
        protected virtual void Details()
        {
            Console.WriteLine("I am from base class : " + name);
        }
    }
}
