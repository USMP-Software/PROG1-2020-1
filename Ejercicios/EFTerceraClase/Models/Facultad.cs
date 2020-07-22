using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFTerceraClase.Models
{
    public class Facultad
    {
        public int Id { get; set; }

        [Required]

        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Dirección de la facultad")]
        public string Direccion { get; set; }
        public List<Carrera> Carreras { get; set; }
    }
}