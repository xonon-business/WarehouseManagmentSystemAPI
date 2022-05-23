




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

    }
}
