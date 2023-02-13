using microserviceSeguros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace microserviceSeguros.Infrastruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
         
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Apolice> Apolice { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Parcela>()
                .HasOne(p => p.apolice)
                .WithMany(a => a.parcelas)
                .HasForeignKey(c => c.apoliceId);
                
                
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Properties.Any(p => p.Metadata.Name == "data_criacao_registro")))
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Property("data_criacao_registro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("data_alteracao_registro").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}