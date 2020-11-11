using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Persistance.EntityFramework.Context
{
    public class VendingMachineDbContext : DbContext
    {

        public DbSet<Status> Statuses { get; set; }
        public DbSet<ProductImage> ProductImages{ get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<StockInventory> StockInventories { get; set; }

        public DbSet<Sale> Sales { get; set; }



        public VendingMachineDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //
            builder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();


                entity.Property(e => e.CreationTime)
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.ActiveStatus)
                    .HasDefaultValue(true);

                entity.Property(e => e.IsDeleted)
                    .HasDefaultValue(false);

                entity.HasIndex(e => e.StatusCode)
                    .IsUnique();
            });
        }
    }
}