using Aula2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aula2.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt) { 
        
        }
    
        public DbSet<Carro> carro {get;set;}
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}