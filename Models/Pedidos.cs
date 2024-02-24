using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrediEco.Models
{
    public class Pedidos
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey(nameof(Clientes))]
        public int ClienteId { get; set; }

        public Clientes Clientes { get; set; }
    }
}
