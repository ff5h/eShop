using eShop.API.BLL.DTOs;
using eShop.API.DAL.Entities;

namespace eShop.API.BLL.Interfaces
{
    public interface ICatalogService
    {
        Task CreateProductAsync(ProductDto product);
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task UpdateProductAsync(int id, Product product);
        Task DeleteProductAsync(int id);
    }
}
