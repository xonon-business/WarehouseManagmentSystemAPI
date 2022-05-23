

namespace WarehouseManagmentSystemAPI.Domain.Entities.OrderEntityRoot
{
    public class OrdersToUsersEntity
    {
        public Guid UserId { get; set; }
        public UserEntity UserEntity { get; set; }
        public OrderEntity OrderEntity { get; set; }
        public Guid OrderId { get; set; }
    }
}
