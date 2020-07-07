using EFPrimeraClase.Models;
using Microsoft.EntityFrameworkCore;

namespace EFPrimeraClase.Data
{
    // Paso 2: Definir la clase contexto
    public class PokemonContext : DbContext
    {
        // Registrar todas las clases que serán tablas en la BD
        public DbSet<Pokemon> Pokemones { get; set; }

        // Registrar un constructor configurable
        public PokemonContext(DbContextOptions dco) : base(dco) {

        }
    }
}