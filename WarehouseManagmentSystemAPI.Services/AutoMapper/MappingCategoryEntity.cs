using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingCategoryEntity:Profile
    {
        public MappingCategoryEntity()
        {
            CreateMap<CategoryEntity, CategoryDto>();
        }
    }
}
