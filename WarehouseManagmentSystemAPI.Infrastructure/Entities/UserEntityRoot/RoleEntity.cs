using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities.UserEntityRoot
{
    public class RoleEntity
    {
        Guid RoleId { get; set; }

        public string RoleType { get; set; }
        public Guid UserId { get; set; }
        public List<UserEntity> Users { get; set; }
    }
}
