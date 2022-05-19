

namespace WarehouseManagmentSystemAPI.Domain.Entities.OrderEntityRoot
{
    public class OrdersToCustomers
    {
        public Guid CustomerId { get; set; }
        public CustomerEntity CustomerEntity { get; set; }
        public OrderEntity  OrderEntity { get; set; }
        public Guid OrderId { get; set; }
    }
}
