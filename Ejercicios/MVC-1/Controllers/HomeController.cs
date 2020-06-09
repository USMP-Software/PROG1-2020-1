using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Abc()
        {
            return View();
        }
    }
}