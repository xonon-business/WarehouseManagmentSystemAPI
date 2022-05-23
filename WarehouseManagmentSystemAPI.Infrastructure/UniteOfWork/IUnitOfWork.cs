

namespace WarehouseManagmentSystemAPI.Infrastructure.UniteOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IBaseRepository<ProductEntity> Products { get; }
        public IBaseRepository<CategoryEntity> Categories { get; }
        public IBaseRepository<CustomerEntity> Customers { get; }
        public IBaseRepository<StockEntity> Stocks { get; }
        public IBaseRepository<OrderEntity> Orders { get; }
        public IBaseRepository<UserEntity> Users { get; }
        public IBaseRepository<RoleEntity> Roles { get; }



    }
}
