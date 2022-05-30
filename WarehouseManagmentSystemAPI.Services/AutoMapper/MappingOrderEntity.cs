
namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingOrderEntity: Profile
    {
        public MappingOrderEntity()
        {
            CreateMap<OrderEntity, OrderDto>();
        }

    }
}
