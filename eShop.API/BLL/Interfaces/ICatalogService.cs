using eShop.API.BLL.DTOs;

namespace eShop.API.BLL.Interfaces
{
    public interface ICatalogService
    {
        Task<ProductDto> CreateProductAsync(NewProductRequestDto product);
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
    }
}
