using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.BLL.Interfaces;
using eShop.API.DAL;
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

        public Task<ProductDto> CreateProductAsync(NewProductRequestDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                throw new Exception("Product with this ID does not exist");
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                PictureUrl = product.PictureUrl,
                Mark = product.Mark
            };
            return productDto;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _ctx.Products.ToArrayAsync();
            var productDtos = products.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                PictureUrl = x.PictureUrl,
                Mark = x.Mark
            });
            return productDtos;
        }
    }
}
