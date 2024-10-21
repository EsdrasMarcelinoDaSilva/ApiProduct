using Microsoft.EntityFrameworkCore;

namespace ApiProduct.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ID = Guid.NewGuid(), Description = "Laptop Dell XPS 13, 11ª Geração Intel Core i7, 16GB RAM, 512GB SSD", Price = 8499.00M },
                new Product { ID = Guid.NewGuid(), Description = "Mouse Logitech MX Master 3, Wireless, 4000 DPI", Price = 499.00M },
                new Product { ID = Guid.NewGuid(), Description = "Teclado Mecânico Corsair K95, RGB, Switch Cherry MX", Price = 1199.00M },
                new Product { ID = Guid.NewGuid(), Description = "Monitor LG UltraWide 34'', WQHD, IPS, 75Hz", Price = 3299.00M },
                new Product { ID = Guid.NewGuid(), Description = "Headset Gamer HyperX Cloud II, Surround 7.1, USB", Price = 799.00M },
                new Product { ID = Guid.NewGuid(), Description = "SSD Samsung 970 EVO Plus 1TB, NVMe M.2", Price = 1199.00M },
                new Product { ID = Guid.NewGuid(), Description = "Placa de Vídeo NVIDIA GeForce RTX 3080, 10GB GDDR6X", Price = 7499.00M },
                new Product { ID = Guid.NewGuid(), Description = "Impressora Multifuncional HP DeskJet 2776, Wi-Fi, Jato de Tinta", Price = 499.00M },
                new Product { ID = Guid.NewGuid(), Description = "Cadeira Gamer DXRacer Formula Series, Ergonomica", Price = 1699.00M },
                new Product { ID = Guid.NewGuid(), Description = "Roteador Wi-Fi TP-Link Archer AX6000, Dual Band, 8 Antenas", Price = 1299.00M }
            );
        }
    }
}
