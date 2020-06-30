using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC02.Models;

namespace PC02.Controllers
{
    public class HomeController : Controller
    {
        // Quiénes somos
        public IActionResult Index()
        {
            return View();
        }

        // Servicios y productos
        public IActionResult Servicios()
        {
            return View();
        }

        // Formulario de contacto
        public IActionResult Contacto()
        {
            return View();
        }

        // Acción para recibir los datos

        [HttpPost]
        public IActionResult Contacto(string mensaje, string nombre)
        {
            return RedirectToAction("Confirmacion");
        }

        // Confirmación del formulario de contacto
        public IActionResult Confirmacion()
        {
            return View();
        }
    }
}
