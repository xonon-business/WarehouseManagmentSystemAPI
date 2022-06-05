using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp
{
    public class CustomerRepositoryImp: BaseRepositoryImp<CustomerEntity>, ICustomerRepository
    {

        private readonly ApplicationDbContext _db;

        public CustomerRepositoryImp(ApplicationDbContext db): base(db)
        {
        }

        public async Task<IQueryable<CustomerEntity>> GetCustomersWithHighOrdering()
        {
            var Customers = await _db.Customer.OrderBy(c => c.Orders).ToListAsync();

            return (IQueryable<CustomerEntity>) Customers;
            
        }

        

    }
}
