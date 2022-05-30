using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IUsersServices
    {
        public ProductDto CreateProduct(ProductDto productsDto);
        public ProductDto UpdateProduct(ProductDto productsDto);
        public void DeleteProduct(Guid id);
        public IEnumerable<ProductDto> ReadProducts(ProductDto productsDto);
    }
}
