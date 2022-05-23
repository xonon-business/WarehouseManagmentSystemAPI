

namespace WarehouseManagmentSystemAPI.Domain.Entities.OrderEntityRoot
{
    public class OrdersToCustomersEntity
    {
        public Guid CustomerId { get; set; }
        public CustomerEntity Customers { get; set; }
        public OrderEntity  Orders { get; set; }
        public Guid OrderId { get; set; }
    }
}
