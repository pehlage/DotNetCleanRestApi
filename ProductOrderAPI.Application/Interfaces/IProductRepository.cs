using ProductOrderAPI.Domain.Entities;

namespace ProductOrderAPI.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
}
