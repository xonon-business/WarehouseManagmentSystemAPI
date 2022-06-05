


using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class ProductsFluentApi : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasOne<CategoryEntity>(p => p.Category).WithMany(c => c.ProductEntities).HasForeignKey(p=>p.CategoryIdFK);
            builder.HasOne<StockEntity>(p => p.Stock).WithMany(s => s.ProductEntity).HasForeignKey(p => p.StockIdFk);
            builder.HasIndex(p => p.ProductName).IsUnique();
        }
    }
}
