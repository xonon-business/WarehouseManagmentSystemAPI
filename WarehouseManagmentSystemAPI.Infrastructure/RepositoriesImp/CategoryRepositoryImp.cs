using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp
{
    public class CategoryRepositoryImp : BaseRepositoryImp<CategoryEntity>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepositoryImp(ApplicationDbContext db) : base(db)
        {
        }

        public CategoryEntity GetCategoryByName(string name)
        {
            var category = _db.Categories.Where(c => c.CategoryName ==name).SingleOrDefault();

            return category;

        }

        public async Task<CategoryEntity> GetCategoryByNameAsync(string name)
        {
            var category = await _db.Categories.Where(c => c.CategoryName == name).SingleOrDefaultAsync();

            return category;
        }
    }
}
