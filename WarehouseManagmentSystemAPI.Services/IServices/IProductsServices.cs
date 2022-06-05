

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IProductsServices:IBaseServices<ProductDto>
    {
       public Task<ProductDto> GetProductByNameAsync(string productName);
       public Task<ProductEntity> UpdateProductById(ProductDto obj,Guid id);
       public  Task<IEnumerable<ProductEntity>> GetAllProductsAsync();
       public Task<ProductDto> GetProductsPricesList();
       public Task<ProductDto> GetProductsLowStockAsync();

    }
}
