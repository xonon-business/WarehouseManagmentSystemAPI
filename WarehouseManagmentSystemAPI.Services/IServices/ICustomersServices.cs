
namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface ICustomersServices:IBaseServices<CustomerDto>
    {
        public Task<CustomerEntity> UpdateCustomerByIdAsync(CustomerDto obj,Guid id);

    }
}
