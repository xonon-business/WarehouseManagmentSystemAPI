using Microsoft.EntityFrameworkCore;

namespace WarehouseManagmentSystemAPI.Prisma {
  public class PrismaClientCS: DbContext {
    public DbSet<User> User { get; set; }
    public DbSet<StockEntity> StockEntity { get; set; }
    public DbSet<ProductEntity> ProductEntity { get; set; }
    public DbSet<CategoryEntity> CategoryEntity { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      
      modelBuilder.Entity<User>()
        .Property(e => e.id)
        .ValueGeneratedOnAdd();
      modelBuilder.Entity<StockEntity>()
        .Property(e => e.ProductId)
        .ValueGeneratedOnAdd();
      modelBuilder.Entity<ProductEntity>()
        .Property(e => e.id)
        .ValueGeneratedOnAdd();
      modelBuilder.Entity<CategoryEntity>()
        .Property(e => e.id)
        .ValueGeneratedOnAdd();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        var connection_string = @"Host=0x9n535gsebb.us-east-3.psdb.cloud;Database=wms-app?sslaccept=strict;Username=21dsto26i1cq;Password=pscale_pw_SEBlUCQoQW0fr8-h0JdRwjh1wQwasnAZAMZBaRKMrf8;";
        optionsBuilder.UseMySql(connection_string, ServerVersion.AutoDetect(connection_string));
    }
  }
}