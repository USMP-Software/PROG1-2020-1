using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiMascota.Models;

namespace MiMascota.Context
{
    public class MiMascotaContext : IdentityDbContext
    {
        public DbSet<Albergue> Albergues { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Adoptante> Adoptantes { get; set; }

        public MiMascotaContext(DbContextOptions dco) : base(dco)
        {

        }
    }
}