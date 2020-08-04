using Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data
{
    public class VeterinariaContext : IdentityDbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }

        public VeterinariaContext(DbContextOptions dco) : base(dco)
        {

        }
    }
}