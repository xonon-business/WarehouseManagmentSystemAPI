using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Domain.UniteOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IBaseRepository<ProductEntity> Products { get; }
        public IBaseRepository<CategoryEntity> Categories { get; }
        public IBaseRepository<CustomerEntity> Customers { get; }

    }
}
