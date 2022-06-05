

namespace WarehouseManagmentSystemAPI.Infrastructure.IRepositories
{
    public interface ICategoryRepository:IBaseRepository<CategoryEntity>
    {
        public CategoryEntity GetCategoryByName(string name);
        public Task<CategoryEntity> GetCategoryByNameAsync(string name);


    }
}