namespace MiMascota.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Albergue Albergue { get; set; }
        public int AlbergueId { get; set; }
        public Adoptante Adoptante { get; set; }
        public int? AdoptanteId { get; set; }
    }
}