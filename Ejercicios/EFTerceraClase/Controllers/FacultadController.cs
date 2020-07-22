using System.Linq;
using EFTerceraClase.Data;
using EFTerceraClase.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFTerceraClase.Controllers
{
    public class FacultadController : Controller
    {
        private UniversidadContext _context;
        public FacultadController(UniversidadContext c)
        {
            _context = c;
        }

        public IActionResult Index()
        {
            var facultades = _context.Facultades.ToList();

            return View(facultades);
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Facultad facultad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facultad);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facultad);
        }
    }
}