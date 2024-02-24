using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrediEco.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Pedidos))]
        public int PedidoId { get; set; }

        public Pedidos Pedidos { get; set; }

        [ForeignKey(nameof(Productos))]
        public int ProductoId { get; set; }

        public Productos Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
    }
}
