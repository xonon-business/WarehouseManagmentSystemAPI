

namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingCustomerEntity:Profile
    {
        public MappingCustomerEntity()
        {
            CreateMap<CustomerEntity, CustomerDto>();
        }
    }
}
