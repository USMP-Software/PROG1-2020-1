using Microsoft.AspNetCore.Mvc;

namespace PC02.Controllers
{
    public class VentasController : Controller
    {
        // Productos en promoción
        public IActionResult Index()
        {
            return View();
        }

        // Catálogo de productos
        public IActionResult Productos()
        {
            return View();
        }

        // Catálogo de servicios
        public IActionResult Servicios()
        {
            return View();
        }
    }
}