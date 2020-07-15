using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFSqlServer.Models;
using EFSqlServer.Data;

namespace EFSqlServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PokemonContext _context;

        public HomeController(ILogger<HomeController> logger, PokemonContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string pueblo)
        {
            var entrenadores = _context.Entrenadores
                                    .Where(e => e.PuebloOrigen == pueblo)
                                    .ToList();

            return View(entrenadores);
        }

        public IActionResult Privacy()
        {
            var entrenador = new Entrenador
            {
                Nombre = "Ash",
                PuebloOrigen = "Pueblo Paleta",
                FechaNacimiento = new DateTime(2000, 1, 1)
            };

            _context.Add(entrenador);
            _context.SaveChanges();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
