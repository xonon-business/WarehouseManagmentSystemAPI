

namespace ResturantWebApi.Domain.Entities.OrderEntityRoot
{
    public class OrderItemsEntity
    {
        public Guid Order_Id { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity_Sold {get;set;}
        public double Price_Per_Unit { get; set; }
        public double Total_Item_Sold { get; set; }
        //navigation Properties
        public ProductEntity ProductEntity { get; set; }
        public OrderEntity OrderEntity { get; set; }

    }
}
