using Microsoft.EntityFrameworkCore;
using pet_register_table.Models;

namespace pet_register_table.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasKey(p => p.Id); 

                entity.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(100); 

                entity.Property(p => p.Species)
                    .IsRequired()
                    .HasMaxLength(50); 

                entity.Property(p => p.Breed)
                    .HasMaxLength(50); 

                entity.Property(p => p.OwnerName)
                    .HasMaxLength(100); 

                entity.Property(p => p.ContactNumber)
                    .HasMaxLength(15); 

                entity.Property(p => p.IsVaccinated)
                    .IsRequired(); 

                entity.Property(p => p.RegisteredAt)
                    .HasDefaultValueSql("GETDATE()");
                
            });
        }
    }
}
