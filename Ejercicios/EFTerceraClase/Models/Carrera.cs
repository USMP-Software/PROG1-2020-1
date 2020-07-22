using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFTerceraClase.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public Facultad Facultad { get; set; }

        // Shadow Property de EF
        public int? FacultadId { get; set; }
    }
}