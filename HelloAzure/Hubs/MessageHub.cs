﻿using HelloAzure.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAzure.Hubs
{
    public class MessageHub : Hub
    {
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
