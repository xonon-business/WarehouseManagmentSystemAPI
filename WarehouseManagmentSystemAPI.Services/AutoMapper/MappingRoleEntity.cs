using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingRoleEntity:Profile
    {
        public MappingRoleEntity()
        {
            CreateMap<RoleEntity,RoleDto>();
            
        }
    }
}
