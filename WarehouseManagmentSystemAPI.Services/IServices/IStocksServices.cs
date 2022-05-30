

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IStocksServices
    {
        public void CreateProduct(ProductDto productsDto);
        public void UpdateProduct(ProductDto productsDto);
        public void DeleteProduct(Guid id);
        public IEnumerable<ProductDto> ReadProducts(ProductDto productsDto);
    }
}
