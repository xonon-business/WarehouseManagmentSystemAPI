

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities
{
    public class StockEntity
    {
        public Guid ProductId { get; set;}
        public List<ProductEntity> ProductEntity { get; set;}
    }
}
