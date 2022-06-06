
namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface ICategoriesServices:IBaseServices<CategoryDto>
    {
        public CategoryDto GetCategoryByName(string CategoryName);

    }
}
