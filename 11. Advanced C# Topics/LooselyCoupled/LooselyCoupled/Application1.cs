using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    //This class is depend on the Interface IApplication
    internal class Application1 : IApplication
    {
        public void Run()
        {
            Console.WriteLine("The Application1 is running.");
        }
    }
}
