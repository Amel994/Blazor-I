using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_I.Server.Habovi
{
    public class NasHub : Hub
    {
        public void TestMetoda(string ulaz)
        {
            Console.WriteLine("Od klijenta: " + ulaz);
            Clients.Caller.SendAsync("KlijentMetoda","Evo poruke od servera");
        }
    }
}
