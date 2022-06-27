using eShop.API.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.API.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.Property(x => x.PictureUrl)
                .IsRequired();

            builder.Property(x => x.Mark)
                .IsRequired();

            builder.HasData(new Product()
            {
                Id = 1,
                Name = "Vintage Typewriter to post awesome stories about UI design and webdev.",
                Description = "Eligible for Shipping To Mars or somewhere else",
                Price = 49.50,
                PictureUrl = "https://www.wired.com/story/stay-in-the-moment-take-a-picture/",
                Mark = 4.05
            });

            builder.HasData(new Product()
            {
                Id = 2,
                Name = "Lee Pucker design. Leather botinki for handsome designers. Free shipping.",
                Description = "1258 bids, 359 watchers $5.95 for shipping",
                Price = 13.95,
                PictureUrl = "https://www.wired.com/story/stay-in-the-moment-take-a-picture/",
                Mark = 4.56
            });
        }
    }
}
