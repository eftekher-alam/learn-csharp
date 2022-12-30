using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    //On this iterface, client, application1 and application2 are dependent.
    internal interface IApplication
    {
        public void Run();
    }
}
