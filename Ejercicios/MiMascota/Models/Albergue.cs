using System.Collections.Generic;

namespace MiMascota.Models
{
    public class Albergue
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}