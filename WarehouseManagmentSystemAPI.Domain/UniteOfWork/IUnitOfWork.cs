
namespace WarehouseManagmentSystemAPI.Domain.UniteOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IBaseRepository<ProductEntity> Products { get; }
        public IBaseRepository<CategoryEntity> Categories { get; }
        public IBaseRepository<CustomerEntity> Customers { get; }

    }
}
