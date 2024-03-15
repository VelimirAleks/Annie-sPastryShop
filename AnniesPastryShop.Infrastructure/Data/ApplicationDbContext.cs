using AnniesPastryShop.Infrastructure.Data.Models;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Annie_sPastryShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<CartItem> CartsItems { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrdersItems { get; set; } = null!;
        public DbSet<PaymentMethod> PaymentsMethods { get; set; } = null!;
        public DbSet<Picture> Pictures { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Administrator> Administrators { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Moderator> Moderators { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CartItem>()
                .HasKey(ci => new { ci.CartId, ci.ProductId });

            builder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId });

            builder.Entity<Review>()
                .HasKey(r => new { r.ProductId, r.CustomerId });

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.Entity<CartItem>()
                .Property(ci => ci.TotalPrice)
                .HasPrecision(18, 2);

            builder.Entity<OrderItem>()
                .Property(oi => oi.TotalPrice)
                .HasPrecision(18, 2);

            builder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasPrecision(18, 2);
        }
    }
}
