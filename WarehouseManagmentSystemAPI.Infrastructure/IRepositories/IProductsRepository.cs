using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.IRepositories
{
    public interface IProductsRepository
    {
        public ProductEntity GetProductByName(string name);
        public Task<ProductEntity> GetProductByNameAsync(string name);

    }
}
