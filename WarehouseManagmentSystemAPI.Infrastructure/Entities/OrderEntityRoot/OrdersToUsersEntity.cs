

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities.OrderEntityRoot
{
    public class OrdersToUsersEntity
    {
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
        public OrderEntity Order { get; set; }
        public Guid OrderId { get; set; }
    }
}
