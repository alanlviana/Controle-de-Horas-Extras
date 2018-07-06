using Microsoft.EntityFrameworkCore;

namespace Chronos.Models{
    public class ExtraContext : DbContext{

        public ExtraContext(DbContextOptions options):base(options){
            this.RegistrosPonto = this.Set<RegistroPonto>();
        }
        public DbSet<RegistroPonto> RegistrosPonto{get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistroPonto>().HasKey(r => r.Id);           
        }
    }
}