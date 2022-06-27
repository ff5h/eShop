using AutoMapper;
using eShop.API.BLL.Interfaces;
using eShop.API.Presentler.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Presentler.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly IMapper _mapper;

        public CatalogController(ICatalogService catalogService, IMapper mapper)
        {
            _catalogService = catalogService;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> GetProductsAsync()
        {
            var productDtos = await _catalogService.GetProductsAsync();
            var contract = productDtos.Select(x => new ProductContract()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                Mark = x.Mark,
                PictureUrl = x.PictureUrl
            });
            return Ok(contract);
        }

        [HttpGet]
        [Route("product/{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync(int id)
        {
            var productDto = await _catalogService.GetProductByIdAsync(id);
            var contract = new ProductContract()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                PictureUrl = productDto.PictureUrl,
                Mark = productDto.Mark
            };
            return Ok(contract);
        }

        [HttpPost]
        [Route("newProduct")]
        public async Task<IActionResult> CreateProductAsync(NewProductContract contract)
        {
            //var product = new ProductDto()
            //{
            //    Name = contract.Name,
            //};
            //await _catalogService.CreateProductAsync(product);

            var result = new ProductContract();
            return Ok(result);
        }
    }
}
