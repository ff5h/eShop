using eShop.API.BLL.Interfaces;
using eShop.API.DAL;
using eShop.API.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.API.BLL.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly CatalogContext _ctx;

        public CatalogService(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CreateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new Exception();
            }
            _ctx.Products.Add(product);
            await _ctx.SaveChangesAsync();
        }

        public async Task<Product[]> GetProductsAsync()
        {
            var products = await _ctx.Products.ToArrayAsync();
            if (products == null)
            {
                throw new Exception();
            }
            return products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new Exception();
            }
            return product;
        }

        public async Task UpdateProductAsync(int id, Product productDto)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new Exception();
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new Exception();
            }
            _ctx.Products.Remove(product);
            await _ctx.SaveChangesAsync();
        }
    }
}
