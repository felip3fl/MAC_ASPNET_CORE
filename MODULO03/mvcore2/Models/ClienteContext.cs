using Microsoft.EntityFrameworkCore;

namespace mvcore2.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes {get;set;}
    }
}