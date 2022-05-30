


namespace WarehouseManagmentSystemAPI.Dtos
{
    public class ProductDto
    {
        public Guid id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? SKU { get; set; }
        public int? ProductQTY { get; set; }
        public int? ReOrderPoint { get; set; }
        public double? ProductSalePrice { get; set; }
        public double? ProductCostPrice { get; set; }
        public byte[]? ProductImage { get; set; }
        public Guid CategoryIdFK { get; set; }
        public CategoryEntity Category { get; set; }
        public virtual string? Message { get; set; } // this is message to display the status code
        public Guid StockIdFk { get; set; }
        public StockEntity Stock { get; set; }
    }
}
