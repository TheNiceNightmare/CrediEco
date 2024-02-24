using Microsoft.EntityFrameworkCore;
using CrediEco.Models;

namespace CrediEco.Data
{
    public class CrediEcoDBContext : DbContext
    {
        public CrediEcoDBContext(DbContextOptions<CrediEcoDBContext> options) : base(options)
        {

        }
        public DbSet<CrediEco.Models.Productos> Productos { get; set; } = default!;
        public DbSet<CrediEco.Models.Clientes> Clientes { get; set; } = default!;
    }
}
