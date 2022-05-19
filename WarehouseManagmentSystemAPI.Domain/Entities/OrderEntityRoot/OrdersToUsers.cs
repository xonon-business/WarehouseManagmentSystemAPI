using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Domain.Entities.OrderEntityRoot
{
    public class OrdersToUsers
    {
        public Guid UserId { get; set; }
        public UserEntity UserEntity { get; set; }
        public OrderEntity OrderEntity { get; set; }
        public Guid OrderId { get; set; }
    }
}
