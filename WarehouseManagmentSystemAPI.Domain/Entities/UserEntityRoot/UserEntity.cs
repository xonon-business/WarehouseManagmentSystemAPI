using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Domain.Entities.UserEntityRoot
{
    public class UserEntity:PersonBaseClass
    {
        Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public RoleEntity Role { get; set; }

    }
}
