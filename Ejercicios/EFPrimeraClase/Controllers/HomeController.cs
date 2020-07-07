using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFPrimeraClase.Models;
using EFPrimeraClase.Data;

namespace EFPrimeraClase.Controllers
{
    public class HomeController : Controller
    {
        // Paso 4a: Definir un atributo privado para guardar el contexto, recibir el valor en el constructor y guardarlo en el atributo privado
        private PokemonContext _context;

        public HomeController(PokemonContext pokemonContext)
        {
            _context = pokemonContext;
        }

        public IActionResult Index()
        {
            var pokemones = _context.Pokemones.ToList();

            ViewData["pokemones"] = pokemones;

            return View();
        }

        public IActionResult Index2()
        {
            var pokemones = _context.Pokemones.ToList();

            return View(pokemones);
        }

        public IActionResult RegistroPokemon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroPokemon(Pokemon pokemon)
        {
            // Paso 4b: Guardar el pokemon usando la clase PokemonContext _context
            // Guardar los datos del pokemon en la BD
            
            _context.Add(pokemon);

            // Commit
            _context.SaveChanges();
            
            return RedirectToAction("Confirmacion");
        }

        public IActionResult Confirmacion()
        {
            return View();
        }
    }
}
