using System.ComponentModel.DataAnnotations;

namespace CrediEco.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public bool Estado { get; set; }
    }
}
