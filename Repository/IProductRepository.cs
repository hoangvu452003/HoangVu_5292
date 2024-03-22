using HoangVu_5292.Models;

namespace HoangVu_5292.Repository
{
    public interface IProductRepository 
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

    }
}
