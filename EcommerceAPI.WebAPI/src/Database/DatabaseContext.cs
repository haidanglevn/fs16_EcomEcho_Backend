using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace EcommerceAPI.WebAPI.src.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _config;
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Image> Images { get; set; }

        static DatabaseContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DatabaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enums
            modelBuilder.HasPostgresEnum<Role>();
            modelBuilder.HasPostgresEnum<Status>();
            modelBuilder.HasPostgresEnum<Color>();
            modelBuilder.HasPostgresEnum<Size>();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(SeedData.Users());
            modelBuilder.Entity<Category>().HasData(SeedData.Categories());
            modelBuilder.Entity<Product>().HasData(SeedData.Products());
            modelBuilder.Entity<Image>().HasData(SeedData.Images());
            modelBuilder.Entity<Variant>().HasData(SeedData.Variants());
            modelBuilder.Entity<Review>().HasData(SeedData.Reviews());
            modelBuilder.Entity<Address>().HasData(SeedData.Addresses());

            // Update/Delete behaviors
            modelBuilder.Entity<User>()
               .HasMany(u => u.Addresses) // User has many Addresses
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade); // Cascade delete behavior

            modelBuilder.Entity<Product>()
               .HasMany(p => p.Images)
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Address>()
                .HasMany(u => u.Orders)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Reviews)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne()
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderItems)
                .WithOne()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Variant>()
                .HasMany(v => v.OrderItems)
                .WithOne()
                .HasForeignKey(oi => oi.VariantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>()
               .HasMany(c => c.Products)
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)  // Each Product has one Category
                .WithMany(c => c.Products)  // Each Category has many Products
                .HasForeignKey(p => p.CategoryId)  // The foreign key is CategoryId
                .OnDelete(DeleteBehavior.Cascade);  // Specify the delete behavior if necessary

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Variants)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            // Unique configuration
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Review>()
                .HasIndex(r => new { r.UserId, r.ProductId })
                .IsUnique();
        }
    }
}