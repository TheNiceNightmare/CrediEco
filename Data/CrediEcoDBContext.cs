using Microsoft.EntityFrameworkCore;
using CrediEco.Models;

namespace CrediEco.Data
{
    public class CrediEcoDBContext : DbContext
    {
        public CrediEcoDBContext(DbContextOptions<CrediEcoDBContext> options) : base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<PedidoDetalle> DetalleDelPedido { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}
