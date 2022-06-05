
namespace WarehouseManagmentSystemAPI.Infrastructure.IRepositories
{
    public interface ICustomerRepository:IBaseRepository<CustomerEntity>
    {
        public Task<IQueryable<CustomerEntity>> GetCustomersWithHighOrdering();

    }
}
