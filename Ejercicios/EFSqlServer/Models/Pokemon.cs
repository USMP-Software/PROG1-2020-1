using System.ComponentModel;

namespace EFSqlServer.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [DefaultValue(1)]
        public int Nivel { get; set; }
        public string Tipo { get; set; }
    }
}