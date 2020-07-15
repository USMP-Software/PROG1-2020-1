using System;
using System.ComponentModel.DataAnnotations;

namespace EFSqlServer.Models
{
    public class Entrenador
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string PuebloOrigen { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}