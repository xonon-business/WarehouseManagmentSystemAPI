

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IStocksServices
    {
        public void CreateProduct(ProductsDto productsDto);
        public void UpdateProduct(ProductsDto productsDto);
        public void DeleteProduct(Guid id);
        public IEnumerable<ProductsDto> ReadProducts(ProductsDto productsDto);
    }
}
