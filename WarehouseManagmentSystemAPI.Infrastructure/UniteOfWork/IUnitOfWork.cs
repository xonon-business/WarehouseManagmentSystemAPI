

namespace WarehouseManagmentSystemAPI.Infrastructure.UniteOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IProductsRepository Products { get; }
        public ICategoryRepository Categories { get; }
        public ICustomerRepository Customers { get; }
        public IBaseRepository<StockEntity> Stocks { get; }
        public IOrderRepository Orders { get; }
        public IBaseRepository<UserEntity> Users { get; }
        public IBaseRepository<RoleEntity> Roles { get; }

        public int Complete();



    }
}
