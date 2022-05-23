

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot
{
    public class OrderToItemsEntity
    {
        public Guid Order_Id { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity_Sold {get;set;}
        public double Price_Per_Unit { get; set; }
        public double Total_Item_Sold { get; set; }
        //navigation Properties
        public ProductEntity Products { get; set; }
        public OrderEntity Orders { get; set; }

    }
}
