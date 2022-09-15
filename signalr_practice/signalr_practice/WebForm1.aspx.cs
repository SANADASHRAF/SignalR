using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signalr_practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //is not from the client of hub and want to call all client
            var context = GlobalHost.ConnectionManager.GetHubContext<chathub>();
            context.Clients.All.recieveMessage("hello from web form");
        }
    }
}