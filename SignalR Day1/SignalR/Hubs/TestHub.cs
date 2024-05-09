using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class TestHub: Hub
    {
        public void sendmessage(string message)
        {
            Clients.All.SendAsync("recievemessage", message);
        }
    }
}
