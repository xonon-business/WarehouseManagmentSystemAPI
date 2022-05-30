


namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingProductEntity:Profile
    {
        public MappingProductEntity()
        {
            CreateMap<ProductDto, ProductEntity>();
        }
    }
}
