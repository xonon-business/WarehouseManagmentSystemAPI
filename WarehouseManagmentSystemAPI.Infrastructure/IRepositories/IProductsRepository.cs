

namespace WarehouseManagmentSystemAPI.Infrastructure.IRepositories
{
    public interface IProductsRepository:IBaseRepository<ProductEntity>
    {
        public ProductEntity GetProductByName(string name);
        public Task<ProductEntity> GetProductByNameAsync(string name);
        public Task<IQueryable<ProductEntity>> GetAllProductsWithPricesAsync();
        public Task<IQueryable<ProductEntity>> GetProductsWithLowStockAsync();
    }
}
