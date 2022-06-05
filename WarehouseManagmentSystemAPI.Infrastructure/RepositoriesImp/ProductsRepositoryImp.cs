

namespace WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp
{
    public class ProductsRepositoryImp : BaseRepositoryImp<ProductEntity>, IProductsRepository
    {

        private readonly ApplicationDbContext _db;
        public ProductsRepositoryImp(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<IQueryable<ProductEntity>> GetAllProductsWithPricesAsync()
        {
            var productsPricinglist = _db.Products
                .ToList()
                .Select(x => new ProductEntity
                {
                    ProductName = x.ProductName,
                    ProductSalePrice = x.ProductSalePrice
                }).ToList();

            return (IQueryable<ProductEntity>)productsPricinglist;
            
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

        public async Task<IQueryable<ProductEntity>> GetProductsWithLowStockAsync()
        {
            var products = _db.Products
                .ToList()
                .Select(x => new ProductEntity 
                {
                    ProductName = x.ProductName,
                    ReOrderPoint = x.ReOrderPoint
                }).ToList();

            return (IQueryable<ProductEntity>)products;


        }
    }
}
