
using BlazorCardapio_proj.Entidades;
using Microsoft.EntityFrameworkCore;

    namespace BlazorCardapio_proj.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
