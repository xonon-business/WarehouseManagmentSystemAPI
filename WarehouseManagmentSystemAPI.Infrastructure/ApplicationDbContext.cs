




namespace WarehouseManagmentSystemAPI.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductsFluentApi());
            modelBuilder.ApplyConfiguration(new CategoriesFluentApi());
            modelBuilder.ApplyConfiguration(new CustomerFluentApi());
            modelBuilder.ApplyConfiguration(new OrderFluentApi());
            

            

        }

        //Creating Tables

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<StockEntity> Stocks { get; set; }
        public DbSet<OrdersToCustomersEntity> ordersToCustomers { get; set; }
        public DbSet<OrdersToUsersEntity> ordersToUsers { get; set; }
        public DbSet<OrderToItemsEntity> orderToItems { get; set; }


    }
}
