using EFTerceraClase.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTerceraClase.Data
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Facultad> Facultades { get; set; }

        public UniversidadContext(DbContextOptions dbo) : base(dbo)
        {

        }
    }
}