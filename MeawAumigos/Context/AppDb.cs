using MeawAumigos.Models;
using Microsoft.EntityFrameworkCore;
namespace MeawAumigos.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Animal> Animais { get; set; }
    }
}
