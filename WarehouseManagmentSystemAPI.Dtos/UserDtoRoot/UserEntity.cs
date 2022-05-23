using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Dtos.UserDtoRoot
{
    public class UserEntity
    {
        public string? User_Name { get; set; } = string.Empty;
        public string? User_email { get; set; } = string.Empty;
        public string? User_Phone { get; set; } = string.Empty;
        public string RoleType { get; set; }

    }
}
