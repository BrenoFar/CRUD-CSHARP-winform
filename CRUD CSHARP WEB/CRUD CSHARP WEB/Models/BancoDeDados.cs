using Microsoft.EntityFrameworkCore;

namespace CRUD_CSHARP_WEB.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database= CRUD CSHARP WEB;Integrated Security=True");
        }
    }
}
