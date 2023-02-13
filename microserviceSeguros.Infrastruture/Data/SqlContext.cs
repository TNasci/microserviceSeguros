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
            //modelBuilder.Entity<Apolice>()
            //    .HasKey(x => x.Id);
            //modelBuilder.Entity<Apolice>().HasMany(x => x.parcelas).WithOne(a => a.apolice).HasForeignKey(c => c.apoliceId);

            modelBuilder.Entity<Parcela>()
                .HasOne(p => p.apolice).WithMany(a => a.parcelas)
                .HasForeignKey(c => c.apoliceId);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("data_criacao_registro") != null))
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