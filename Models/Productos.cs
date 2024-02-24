using System.ComponentModel.DataAnnotations;

namespace CrediEco.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
    }
}
