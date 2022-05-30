using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot
{
    public class UserEntity:PersonBaseClass
    {
        public Guid Id { get; set; }
        public string User_Name { get; set; }
        public Guid RoleId { get; set; }
        public RoleEntity Role { get; set; }
        public ICollection<OrderEntity> orders { get; set; }
        public List<OrdersToUsersEntity> ordersToUsers { get; set; }

      


    }
}
