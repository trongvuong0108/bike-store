using BikeShop.Domain.Entities;
using BikeShop.Infrastructure.Base;
using BikeShop.Infrastructure.DBContext;
namespace BikeShop.Application.Products
{

    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(BikeShopDBContext _bikeShopDBContext) : base(_bikeShopDBContext)
        {
        }
    }
    public class ProductService
    {
        private ProductRepository _productRepository { get; set; }
        public ProductService(ProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IQueryable<Product> GetProducts()
        {
            var result = _productRepository.FindAll();
            return result;
        }
    }
}
