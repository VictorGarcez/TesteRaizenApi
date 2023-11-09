using Microsoft.EntityFrameworkCore;

namespace Teste.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public Context(DbContextOptions<Context> opcoes) : base(opcoes)
        {
            
        }
    }
}