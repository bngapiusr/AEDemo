using Microsoft.EntityFrameworkCore;

namespace AEEFCore3.Data.Models
{
    public partial class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {
        }
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CreditCardNumber).HasMaxLength(16);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}


