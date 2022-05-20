using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp;

namespace WarehouseManagmentSystemAPI.Domain
{
    public class UnitOfWorkImp : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IBaseRepository<ProductEntity> Products { get; private set; }
        public IBaseRepository<CategoryEntity> Categories { get; private set; }
        public IBaseRepository<CustomerEntity> Customers { get; private set; }

        public UnitOfWorkImp(ApplicationDbContext db)
        {
            _db = db;

            Products = new BaseRepositoryImp<ProductEntity>(_db);
            Categories = new BaseRepositoryImp<CategoryEntity>(_db);
            Customers = new BaseRepositoryImp<CustomerEntity>(_db);

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
