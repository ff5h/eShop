using AutoMapper;
using eShop.API.BLL.DTOs;
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
            var contract = _mapper.Map<ProductContract[]>(productDtos);
            return Ok(contract);
        }

        [HttpGet]
        [Route("product/{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync(int id)
        {
            var productDto = await _catalogService.GetProductByIdAsync(id);
            var contract = _mapper.Map<ProductContract>(productDto);
            return Ok(contract);
        }

        [HttpPost]
        [Route("newProduct")]
        public async Task<IActionResult> CreateProductAsync(NewProductContract contract)
        {
            var productDto = _mapper.Map<NewProductRequestDto>(contract);
            int productId = await _catalogService.CreateProductAsync(productDto);
            return Ok(productId);
        }

        [HttpDelete]
        [Route("delProduct/{id:int}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            var result = await _catalogService.DeleteProductAsync(id);
            if (result != true)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
