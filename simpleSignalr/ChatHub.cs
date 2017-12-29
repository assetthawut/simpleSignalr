using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace simpleSignalr
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void ShowAllClient(string name)
        {
            string[] a = new string[10];
            a[1] = Clients.Caller.userName;
            a[0] = name;
            Clients.All.clientOnline(name);
        }

        public void RealtimeData() {
            //Random sampleRandom = new Random();
            // int number = sampleRandom.Next(1000);
            int number = 1; 
            Clients.All.realtime(number);
        }
    }
}