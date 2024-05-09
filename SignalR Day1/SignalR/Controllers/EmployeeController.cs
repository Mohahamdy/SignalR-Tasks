using Microsoft.AspNetCore.Mvc;
using SignalR.Models;

namespace SignalR.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ITIContext context;

        public EmployeeController(ITIContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var emps = context.Employees.ToList();

            return View(emps);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
