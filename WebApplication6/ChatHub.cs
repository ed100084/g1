using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WebApplication6.Models;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication6
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        static IHubContext HubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        public void SendMessage(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        public void SendMessage(IEnumerable<Message> messages)
        {
            Clients.All.broadcastMessage(messages);
        }
    }
}