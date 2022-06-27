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

        public Task<ProductDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _ctx.Products.ToArrayAsync();
            var result = products.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                PictureUrl = x.PictureUrl,
                Mark = x.Mark,
                Price = x.Price,
            });
            return result;
        }
    }
}
