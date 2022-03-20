using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }


        public async Task OnConnected(string user)
        {
            await Clients.All.SendAsync("UserConnected", user);
        }
    }
}
