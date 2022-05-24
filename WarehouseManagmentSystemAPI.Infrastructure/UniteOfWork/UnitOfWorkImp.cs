




namespace WarehouseManagmentSystemAPI.Infrastructure
{
    public class UnitOfWorkImp : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductsRepository Products { get; private set; }
        public IBaseRepository<CategoryEntity> Categories { get; private set; }
        public IBaseRepository<CustomerEntity> Customers { get; private set; }

        public IBaseRepository<StockEntity> Stocks { get; private set; }

        public IBaseRepository<OrderEntity> Orders { get; private set; }

        public IBaseRepository<UserEntity> Users { get; private set; }

        public IBaseRepository<RoleEntity> Roles { get; private set; }

        public UnitOfWorkImp(ApplicationDbContext db)
        {
            _db = db;

            Products = new ProductsRepositoryImp(_db);
            Categories = new BaseRepositoryImp<CategoryEntity>(_db);
            Customers = new BaseRepositoryImp<CustomerEntity>(_db);
            Stocks = new BaseRepositoryImp<StockEntity>(_db);
            Orders = new BaseRepositoryImp<OrderEntity>(_db);
            Users = new BaseRepositoryImp<UserEntity>(_db);
            Roles = new BaseRepositoryImp<RoleEntity>(_db);

        }

        public int Complete() // this funciton will return the number of rows that been affected by my transactions inside the db 
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
