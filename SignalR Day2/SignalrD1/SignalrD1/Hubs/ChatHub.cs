using Microsoft.AspNetCore.SignalR;
using SignalrD1.Models;
namespace SignalrD1.Hubs
{
    public class ChatHub:Hub
    {
        ITIContext db;
        public ChatHub(ITIContext db)
        {
            this.db = db; 
        }
        //public void sendmessage(string name , string message)
        //{
        //    //save in DB
        //    chatmessage mess = new chatmessage()
        //    {
        //        username = name,
        //        messagetxt = message
        //    };
        //    db.chatmessages.Add(mess);
        //    db.SaveChanges();


        //    //broadcasting to all online clients
        //    Clients.All.SendAsync("newmessage", name, message);
        //}

        public void sendmessage(chatmessage mess)
        {
            //save in DB
            
            db.chatmessages.Add(mess);
            db.SaveChanges();


            //broadcasting to all online clients
            Clients.All.SendAsync("newmessage",mess);
        }

        public void joingroup(string groupname,string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId,groupname);

            Clients.OthersInGroup(groupname).SendAsync("notifygroup",name,groupname);
        }

        public void sendmesstogroup(string groupname,string mess,string name) 
        {
            Clients.All.SendAsync("sendtogroup",groupname,mess,name);
        }
    }
}
