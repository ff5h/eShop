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

        public async Task<int> CreateProductAsync(NewProductRequestDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _ctx.Products.AddAsync(product);
            await _ctx.SaveChangesAsync();
            var productId = product.Id;
            return productId;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                throw new Exception("Product with this ID does not exist");
            _ctx.Products.Remove(product);
            await _ctx.SaveChangesAsync();
            return true;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                throw new Exception("Product with this ID does not exist");
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _ctx.Products.ToArrayAsync();
            var productDtos = _mapper.Map<ProductDto[]>(products);
            return productDtos;
        }
    }
}
