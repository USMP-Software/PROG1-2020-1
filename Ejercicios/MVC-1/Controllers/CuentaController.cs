using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}