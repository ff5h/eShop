using eShop.API.DAL.Entities;
using eShop.API.DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace eShop.API.DAL
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }

        public DbSet<CatalogItem> CatalogItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CatalogItemEntityTypeConfiguration());
        }
    }
}
