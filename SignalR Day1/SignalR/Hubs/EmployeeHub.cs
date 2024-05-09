using Microsoft.AspNetCore.SignalR;
using SignalR.Models;

namespace SignalR.Hubs
{
    public class EmployeeHub:Hub
    {
        private readonly ITIContext context;

        public EmployeeHub(ITIContext context)
        {
            this.context = context;
        }
        public void addemp(Employee emp)
        {
            Clients.All.SendAsync("add",emp);

            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
