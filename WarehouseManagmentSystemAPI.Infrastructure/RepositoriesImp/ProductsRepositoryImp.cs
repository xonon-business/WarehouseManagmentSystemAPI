

namespace WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp
{
    public class ProductsRepositoryImp : BaseRepositoryImp<ProductEntity>, IProductsRepository
    {

        private readonly ApplicationDbContext _db;
        public ProductsRepositoryImp(ApplicationDbContext db) : base(db)
        {
        }

        public ProductEntity GetProductByName(string name)
        {
            var product = _db.Products.Where(p=>p.ProductName == name).Include(p =>p.Category).SingleOrDefault();

            return product;

        }
        public async Task<ProductEntity> GetProductByNameAsync(string name)
        {
            var product = await _db.Products.Where(p => p.ProductName == name).Include(p => p.Category).SingleOrDefaultAsync();

            return product;

        }
    }
}
