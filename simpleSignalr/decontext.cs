using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace simpleSignalr
{
    public class Decontext
    {
        public void Testmethod(String message)
        {

            var hubContext = GlobalHost.ConnectionManager.GetHubContext<SampleContext>();
            hubContext.Clients.All.ShowData(message);

        }
    }
}