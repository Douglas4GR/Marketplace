using Marketplace.Models;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Data
{
    public class MarketplaceContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public MarketplaceContext(DbContextOptions<MarketplaceContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(o => new { o.OrderId, o.OrderItemId });
            modelBuilder.Entity<Product>().HasKey(p => p.Sku);
        }
    }
}
