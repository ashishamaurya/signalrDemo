using Microsoft.AspNetCore.Mvc;

namespace signalrDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
