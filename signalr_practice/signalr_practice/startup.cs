using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(signalr_practice.startup))]

namespace signalr_practice
{
    public class startup
    {
        //entrypoint such as main for start signalr
        public void Configuration(IAppBuilder app)
        {
            //any signalr request (هيعدى عليها الاول)
            app.MapSignalR();
        }
    }
}
