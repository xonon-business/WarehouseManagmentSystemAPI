
namespace WarehouseManagmentSystemAPI.Infrastructure.Entities
{

    public class ProductEntity
    {
        [Key]
        public Guid id { get; set; }
        [MaxLength(60)]
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? SKU { get; set; }
        public int? ProductQTY { get; set; }
        public int? ReOrderPoint { get; set; }
        public double? ProductSalePrice { get; set; }
        public double? ProductCostPrice { get; set; }
        public byte[]? ProductImage { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryIdFK { get; set; }
        public CategoryEntity Category { get; set; }
        public List<OrderToItemsEntity> OrdersItems { get; set;}
        public ICollection<OrderEntity> orders { get; set; }
        [ForeignKey("Stock")]
        public Guid StockIdFk { get; set; }
        public StockEntity Stock { get; set; }

    }
}
