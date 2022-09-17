using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace signalr_practice
{
    //for change name when cleint deal with it
    [HubName("chat")]

    public class chathub : Hub
    {
        //method for client to conect with server
        
        public void SendMessage(string msg)
        {
            //هيبعت الرسالة دى لكل اللى موجدين ماعدا اللى باعتها 
            Clients.Others.recieveMessage("new massege");

            //for deal with all clieent
            Clients.All.recieveMessage($"{msg}");
            
            //هتروح للى باعت الرسالة بس مش هتوصل لباقى الموجودين
            Clients.Caller.recieveMessage("sent");

            
        }



        //method for groub
        public void groupSendMessage(string groubname,string msg)
        {
            Clients.Group(groubname).recieveMessage(msg);
        }

        public async Task joingroub(string groubname)
        {
             await Groups.Add(Context.ConnectionId, groubname);
            Clients.Group(groubname).recieveMessage($"{Context.ConnectionId} :join for groub {groubname}");
        }



        public override Task OnConnected()
        {
            Clients.All.recieveMessage($"{Context.ConnectionId} :is conected");
            return base.OnConnected();
        }


        //this parameter to showing if it forced for disconected or problem in connection
        public override Task OnDisconnected(bool stopCalled)
        {
            Clients.All.recieveMessage($"{Context.ConnectionId} :is disconected");
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            Clients.All.recieveMessage($"{Context.ConnectionId} :is reconected");
            return base.OnReconnected();
        }
    }
}