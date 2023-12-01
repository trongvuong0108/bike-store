using BikeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BikeShop.Infrastructure.DBContext
{
    public class BikeShopDBContext : DbContext
    {
        public DbSet<Product> Products { set; get; }
        public BikeShopDBContext()
        {
        }
        public BikeShopDBContext(DbContextOptions<BikeShopDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=mssql; Initial Catalog=BikeStores; User ID=sa; pwd=Password@1234; MultipleActiveResultSets = True; TrustServerCertificate = True");
        }
    }
}
