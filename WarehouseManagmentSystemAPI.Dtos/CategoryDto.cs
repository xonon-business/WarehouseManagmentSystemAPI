
namespace WarehouseManagmentSystemAPI.Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public List<ProductEntity> ProductsList { get; set; }
        public string Message { get; set; }
    }
}
