using EFSqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSqlServer.Data
{
    public class PokemonContext : DbContext
    {
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Pokemon> Pokemones { get; set; }

        public PokemonContext(DbContextOptions dbo) : base(dbo)
        {

        }
    }
}