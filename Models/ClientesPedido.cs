using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrediEco.Models
{
    public class ClientesPedido
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Clientes))]
        public int ClientesId { get; set; }

        public Clientes Clientes { get; set; }

        [ForeignKey(nameof(Pedidos))]
        public int PedidoId { get; set; }

        public Pedidos Pedidos { get; set; }
       
    }
}
