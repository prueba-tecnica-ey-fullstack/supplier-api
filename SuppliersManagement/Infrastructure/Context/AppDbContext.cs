using Microsoft.EntityFrameworkCore;
using SuppliersManagement.Domain.Entities;

namespace SuppliersManagement.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>(supplier =>
            {
                supplier.HasKey(s => s.Id);
                supplier.Property(s => s.Id)
                        .ValueGeneratedOnAdd();

                supplier.Property(s => s.CreatedDate)
                        .IsRequired()
                        .HasDefaultValueSql("GETDATE()");

                supplier.Property(s => s.UpdatedDate)
                        .IsRequired();

                supplier.Property(s => s.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                supplier.Property(s => s.LegalName)
                      .IsRequired()
                      .HasMaxLength(200);

                supplier.Property(s => s.TaxIdentification)
                      .IsRequired()
                      .HasMaxLength(11);

                supplier.Property(s => s.Phone)
                      .IsRequired()
                      .HasMaxLength(15);

                supplier.Property(s => s.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                supplier.Property(s => s.Website)
                      .IsRequired()
                      .HasMaxLength(100);

                supplier.Property(s => s.Address)
                      .IsRequired()
                      .HasMaxLength(300);

                supplier.Property(s => s.Country)
                      .IsRequired()
                      .HasMaxLength(100);

                supplier.Property(s => s.AnnualBilling)
                      .IsRequired()
                      .HasColumnType("decimal(18,2)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
