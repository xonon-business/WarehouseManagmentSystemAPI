
namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingStockEntity:Profile
    {

        public MappingStockEntity()
        {
            CreateMap<StockEntity,StockDto>();
        }

    }
}
