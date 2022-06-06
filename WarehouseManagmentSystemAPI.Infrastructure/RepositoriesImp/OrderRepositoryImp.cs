
namespace WarehouseManagmentSystemAPI.Infrastructure.RepositoriesImp
{
    public class OrderRepositoryImp : BaseRepositoryImp<OrderEntity>, IOrderRepository
    {

        private readonly ApplicationDbContext _db;
        public OrderRepositoryImp(ApplicationDbContext db) : base(db)
        {
        }



    }
}
