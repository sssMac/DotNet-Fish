using Microsoft.AspNetCore.SignalR;

namespace Fish_js_asp
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Send", message);
        }
    }
}
