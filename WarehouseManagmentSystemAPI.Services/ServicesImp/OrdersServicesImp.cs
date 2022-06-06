using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class OrdersServicesImp : BaseServicesImp<OrderDto>, IOrdersServices
    {
        public OrdersServicesImp(IBaseRepository<OrderDto> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        
    }
}
