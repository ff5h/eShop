using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.BLL.Interfaces;
using eShop.API.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controllers
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
            try
            {
                var result = await _catalogService.GetProductsAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("products /{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync(int id)
        {
            var result = await _catalogService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("product")]
        public async Task<IActionResult> CreateProductAsync(CreateProductContract contract)
        {
            var product = new ProductDto()
            {
                Name = contract.Name,
            };
            await _catalogService.CreateProductAsync(product);
            return Ok();
        }
    }
}
