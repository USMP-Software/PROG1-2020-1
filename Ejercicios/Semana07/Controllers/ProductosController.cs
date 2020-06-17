using Microsoft.AspNetCore.Mvc;
using Semana07.Models;

namespace Semana07.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult NuevoProducto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(Producto producto)
        {
            // TODO - Guardar el nombre y el precio en la BD
            TempData["nombre"] = producto.Nombre;
            return RedirectToAction("NuevoProductoConfirmacion");
        }

        public IActionResult NuevoProductoConfirmacion()
        {
            ViewData["nombre"] = TempData["nombre"];
            return View();
        }
    }
}