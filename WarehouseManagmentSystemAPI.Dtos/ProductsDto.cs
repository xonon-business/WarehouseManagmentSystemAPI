


namespace WarehouseManagmentSystemAPI.Dtos
{
    public class ProductsDto
    {
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? SKU { get; set; }
        public int? ProductQTY { get; set; }
        public int? ReOrderPoint { get; set; }
        public double? ProductSalePrice { get; set; }
        public double? ProductCostPrice { get; set; }
        public byte[]? ProductImage { get; set; }
        public string CategoryType { get; set; }
        public int Quantity_Sold { get; set; }
        public double Price_Per_Unit { get; set; }
        public double Total_Item_Sold { get; set; }

        public string? Message { get; set; } // this is message to display the status code 
    }
}
