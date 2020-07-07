
using System.ComponentModel.DataAnnotations;

namespace EFPrimeraClase.Models
{
    // Paso 1: Definir una clase
    public class Pokemon
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Tipo { get; set; }
    }
}