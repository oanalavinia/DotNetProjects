using Microsoft.EntityFrameworkCore;

namespace Data
{
    sealed class ProductManagement : DbContext
    {
        public ProductManagement()
        {   
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            modelBuilder.Entity<Customer>()
                .Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(300);

             modelBuilder.Entity<Customer>()
                .Property(c => c.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .IsRequired();

        }
    }
}
