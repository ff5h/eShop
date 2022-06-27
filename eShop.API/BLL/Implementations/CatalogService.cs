using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.BLL.Interfaces;
using eShop.API.DAL;
using eShop.API.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.API.BLL.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly CatalogContext _ctx;
        private readonly IMapper _mapper;

        public CatalogService(CatalogContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task CreateProductAsync(ProductDto productDTO)
        {
            var product = new Product()
            {
                Name = productDTO.Name,
            };

            if (product == null)
            {
                throw new Exception();
            }
            _ctx.Products.Add(product);
            await _ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _ctx.Products.ToArrayAsync();
            if (products == null)
            {
                throw new Exception();
            }
            var result = _mapper.Map<ProductDto[]>(products);
            return result;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new Exception();
            }
            var result = _mapper.Map<ProductDto>(product);
            return result;
        }

        public async Task UpdateProductAsync(int id, Product productDto) //TODO
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
