

using WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp;

namespace WarehouseManagmentSystemAPI.Services.ServicesImp
{
    public class ProductsServicesImp : IProductsServices
    {
        private IProductsRepository _productsRepository;
        public ProductsServicesImp(IProductsRepository productsRepository)
        {
                _productsRepository = productsRepository;
        }

        public ProductsDto GetProductByName(string productName)
        {
            var product = _productsRepository.GetProductByName(productName);

            if(product == null)
            {
                return new ProductsDto { Message = "Product Not Found"};
            }

            return product;

        }
    }
}
