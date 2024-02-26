
using BikeShop.Domain.Entities;

namespace BikeShop.Domain.Abstraction.Repositories
{
    public interface IProductRepository
    {
        Task<IQueryable<Product>> GetProductsAsync();
    }
}
