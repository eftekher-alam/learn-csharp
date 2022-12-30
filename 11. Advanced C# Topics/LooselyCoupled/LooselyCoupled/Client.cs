using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    internal class Client
    {
        private IApplication appService;
        public Client(IApplication appService)
        {
            this.appService = appService;
        }
        public void UseApp()
        {
            /*
             -> Here client is depend on IApplication Interface not on Application1 and application2.
             -> Although, client not depend on Application1 or Application2, client can use Application1 and Application2 without making change inside the client class(Have a look Program.cs).
            */

            appService.Run(); 
        }
    }
}
