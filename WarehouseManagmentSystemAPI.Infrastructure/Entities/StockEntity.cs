

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities
{
    [Index(nameof(StockName),IsUnique =true)]
    public class StockEntity
    {
        [Key]
        public Guid StockId { get; set; }
        public string StockName { get; set; }
        public Guid ProductId { get; set;}
        public List<ProductEntity> ProductEntity { get; set;}
    }
}
