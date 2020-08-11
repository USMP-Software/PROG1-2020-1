using System;
using System.Collections.Generic;

namespace MiMascota.Models
{
    public class Adoptante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}