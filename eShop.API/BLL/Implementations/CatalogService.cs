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

        //public async Task CreateProductAsync(ProductDto productDTO)
        //{
        //    var product = new Product()
        //    {
        //        Name = productDTO.Name,
        //    };

        //    if (product == null)
        //    {
        //        throw new Exception();
        //    }
        //    _ctx.Products.Add(product);
        //    await _ctx.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        //{
        //    var products = await _ctx.Products.ToArrayAsync();
        //    if (products == null)
        //    {
        //        throw new Exception();
        //    }
        //    var result = _mapper.Map<ProductDto[]>(products);
        //    return result;
        //}

        //public async Task<ProductDto> GetProductByIdAsync(int id)
        //{
        //    var product = await _ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
        //    if (product == null)
        //    {
        //        throw new Exception();
        //    }
        //    var result = _mapper.Map<ProductDto>(product);
        //    return result;
        //}
    }
}
