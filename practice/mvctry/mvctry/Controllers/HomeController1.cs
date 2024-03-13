using Microsoft.AspNetCore.Mvc;

namespace mvctry.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
