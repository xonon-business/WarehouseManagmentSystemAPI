using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IOrdersServices
    {
        public ProductsDto CreateProduct(ProductsDto productsDto);
        public ProductsDto UpdateProduct(ProductsDto productsDto);
        public void DeleteProduct(Guid id);
        public IEnumerable<ProductsDto> ReadProducts(ProductsDto productsDto);
    }
}
