using Microsoft.AspNetCore.Mvc;

namespace SignalR.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Text() 
        {
            return View();
        }
    }
}
