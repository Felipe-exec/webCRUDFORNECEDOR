using Microsoft.EntityFrameworkCore;

namespace WebCRUDFORNECEDOR.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { 
            
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
    }
}
