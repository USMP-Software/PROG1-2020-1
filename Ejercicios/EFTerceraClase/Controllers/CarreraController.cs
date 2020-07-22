using System.Linq;
using EFTerceraClase.Data;
using EFTerceraClase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EFTerceraClase.Controllers
{
    public class CarreraController : Controller
    {
        private UniversidadContext _context;
        public CarreraController(UniversidadContext c)
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var carreras = _context.Carreras.Include(c => c.Facultad).ToList();
            return View(carreras);
        }

        public IActionResult Registro()
        {
            var facultades = _context.Facultades.ToList();
            ViewBag.Facultades = facultades.Select(f => new SelectListItem(f.Nombre, f.Id.ToString()));

            return View();
        }

        [HttpPost]
        public IActionResult Registro(Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrera);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carrera);
        }
    }
}