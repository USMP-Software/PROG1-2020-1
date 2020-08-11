using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MiMascota.Context;
using MiMascota.Models;

namespace MiMascota.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private MiMascotaContext _context;
        public HomeController(MiMascotaContext context)
        {
            _context = context;
        }

        public IActionResult RegistroAlbergue()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroAlbergue(Albergue albergue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albergue);
                _context.SaveChanges();

                return RedirectToAction("RegistroAlbergueConfirmacion");
            }

            return View(albergue);
        }

        public IActionResult RegistroAlbergueConfirmacion()
        {
            return View();
        }

        public IActionResult RegistroMascota()
        {
            ViewBag.Albergues = _context.Albergues.ToList().Select(a => new SelectListItem(a.Nombre, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult RegistroMascota(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mascota);
                _context.SaveChanges();

                return RedirectToAction("RegistroMascotaConfirmacion");
            }

            ViewBag.Albergues = _context.Albergues.ToList();

            return View(mascota);
        }

        public IActionResult RegistroMascotaConfirmacion()
        {
            return View();
        }
    }
}
