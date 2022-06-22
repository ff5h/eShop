using eShop.API.DAL.Entities;

namespace eShop.API.BLL.Interfaces
{
    public interface ICatalogService
    {
        Task CreateProductAsync(Product product);
        Task<Product[]> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task UpdateProductAsync(int id, Product product);
        Task DeleteProductAsync(int id);
    }
}
